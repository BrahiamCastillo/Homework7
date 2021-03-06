CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `personas` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `cedula` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `nombre` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `apellido` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `fecha_nacimiento` datetime NOT NULL,
    CONSTRAINT `PK_personas` PRIMARY KEY (`id`)
);

CREATE TABLE `provincias` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `nombre_provincia` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    CONSTRAINT `PK_provincias` PRIMARY KEY (`id`)
);

CREATE TABLE `vacunas` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `marca` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `cantidad` int(11) NOT NULL,
    CONSTRAINT `PK_vacunas` PRIMARY KEY (`id`)
);

CREATE TABLE `auditorias` (
    `personas_id` int(11) NOT NULL,
    `vacunas_id` int(11) NOT NULL,
    `provincias_id` int(11) NOT NULL,
    `numero_dosis` int(11) NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`personas_id`, `vacunas_id`, `provincias_id`),
    CONSTRAINT `fk_auditorias_personas` FOREIGN KEY (`personas_id`) REFERENCES `personas` (`id`) ON DELETE RESTRICT,
    CONSTRAINT `fk_auditorias_provincias1` FOREIGN KEY (`provincias_id`) REFERENCES `provincias` (`id`) ON DELETE RESTRICT,
    CONSTRAINT `fk_auditorias_vacunas1` FOREIGN KEY (`vacunas_id`) REFERENCES `vacunas` (`id`) ON DELETE RESTRICT
);

CREATE INDEX `fk_auditorias_provincias1_idx` ON `auditorias` (`provincias_id`);

CREATE INDEX `fk_auditorias_vacunas1_idx` ON `auditorias` (`vacunas_id`);

CREATE UNIQUE INDEX `cedula_UNIQUE` ON `personas` (`cedula`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210305194829_database_generating', '3.1.12');

ALTER TABLE `auditorias` ADD `fecha_vacunacion` datetime(6) NOT NULL DEFAULT '2021-03-05 20:08:16.090922';

ALTER TABLE `auditorias` ADD `fecha_vacunaproxima` datetime(6) NOT NULL DEFAULT '2021-06-05 00:00:00';

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210305222845_Add_columns_to_dates', '3.1.12');

INSERT INTO `vacunas` (`id`, `cantidad`, `marca`)
VALUES (1, 10, 'Covid19');

INSERT INTO `vacunas` (`id`, `cantidad`, `marca`)
VALUES (2, 15, 'Lepra');

INSERT INTO `vacunas` (`id`, `cantidad`, `marca`)
VALUES (3, 6, 'AH1N1');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210305235934_seed_vacuna', '3.1.12');