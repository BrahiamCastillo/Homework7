using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework7.Models
{
    public partial class vacunasContext : DbContext
    {
        public vacunasContext()
        {
        }

        public vacunasContext(DbContextOptions<vacunasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auditorias> Auditorias { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistory { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Vacunas> Vacunas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditorias>(entity =>
            {
                entity.HasKey(e => new { e.PersonasId, e.VacunasId, e.ProvinciasId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("auditorias");

                entity.HasIndex(e => e.ProvinciasId)
                    .HasName("fk_auditorias_provincias1_idx");

                entity.HasIndex(e => e.VacunasId)
                    .HasName("fk_auditorias_vacunas1_idx");

                entity.Property(e => e.PersonasId)
                    .HasColumnName("personas_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VacunasId)
                    .HasColumnName("vacunas_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvinciasId)
                    .HasColumnName("provincias_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaVacunacion)
                    .HasColumnName("fecha_vacunacion")
                    .HasDefaultValueSql("'2021-03-09 19:57:43.656962'");

                entity.Property(e => e.FechaVacunaproxima)
                    .HasColumnName("fecha_vacunaproxima")
                    .HasDefaultValueSql("'2021-06-09 00:00:00.000000'");

                entity.Property(e => e.NumeroDosis)
                    .HasColumnName("numero_dosis")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Personas)
                    .WithMany(p => p.Auditorias)
                    .HasForeignKey(d => d.PersonasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auditorias_personas");

                entity.HasOne(d => d.Provincias)
                    .WithMany(p => p.Auditorias)
                    .HasForeignKey(d => d.ProvinciasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auditorias_provincias1");

                entity.HasOne(d => d.Vacunas)
                    .WithMany(p => p.Auditorias)
                    .HasForeignKey(d => d.VacunasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auditorias_vacunas1");
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(95)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.ToTable("personas");

                entity.HasIndex(e => e.Cedula)
                    .HasName("cedula_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.ToTable("provincias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreProvincia)
                    .IsRequired()
                    .HasColumnName("nombre_provincia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Vacunas>(entity =>
            {
                entity.ToTable("vacunas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
