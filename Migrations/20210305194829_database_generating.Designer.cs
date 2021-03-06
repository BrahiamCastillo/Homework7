﻿// <auto-generated />
using System;
using Homework7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Homework7.Migrations
{
    [DbContext(typeof(vacunasContext))]
    [Migration("20210305194829_database_generating")]
    partial class database_generating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Homework7.Models.Auditorias", b =>
                {
                    b.Property<int>("PersonasId")
                        .HasColumnName("personas_id")
                        .HasColumnType("int(11)");

                    b.Property<int>("VacunasId")
                        .HasColumnName("vacunas_id")
                        .HasColumnType("int(11)");

                    b.Property<int>("ProvinciasId")
                        .HasColumnName("provincias_id")
                        .HasColumnType("int(11)");

                    b.Property<int>("NumeroDosis")
                        .HasColumnName("numero_dosis")
                        .HasColumnType("int(11)");

                    b.HasKey("PersonasId", "VacunasId", "ProvinciasId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                    b.HasIndex("ProvinciasId")
                        .HasName("fk_auditorias_provincias1_idx");

                    b.HasIndex("VacunasId")
                        .HasName("fk_auditorias_vacunas1_idx");

                    b.ToTable("auditorias");
                });

            modelBuilder.Entity("Homework7.Models.Personas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("apellido")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnName("cedula")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnName("fecha_nacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Id");

                    b.HasIndex("Cedula")
                        .IsUnique()
                        .HasName("cedula_UNIQUE");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Homework7.Models.Provincias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("NombreProvincia")
                        .IsRequired()
                        .HasColumnName("nombre_provincia")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Id");

                    b.ToTable("provincias");
                });

            modelBuilder.Entity("Homework7.Models.Vacunas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int>("Cantidad")
                        .HasColumnName("cantidad")
                        .HasColumnType("int(11)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnName("marca")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Id");

                    b.ToTable("vacunas");
                });

            modelBuilder.Entity("Homework7.Models.Auditorias", b =>
                {
                    b.HasOne("Homework7.Models.Personas", "Personas")
                        .WithMany("Auditorias")
                        .HasForeignKey("PersonasId")
                        .HasConstraintName("fk_auditorias_personas")
                        .IsRequired();

                    b.HasOne("Homework7.Models.Provincias", "Provincias")
                        .WithMany("Auditorias")
                        .HasForeignKey("ProvinciasId")
                        .HasConstraintName("fk_auditorias_provincias1")
                        .IsRequired();

                    b.HasOne("Homework7.Models.Vacunas", "Vacunas")
                        .WithMany("Auditorias")
                        .HasForeignKey("VacunasId")
                        .HasConstraintName("fk_auditorias_vacunas1")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
