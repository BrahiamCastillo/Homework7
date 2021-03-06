using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Homework7.Migrations
{
    public partial class Add_columns_to_dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_vacunacion",
                table: "auditorias",
                defaultValue: DateTime.Now,
                nullable: false
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_vacunaproxima",
                table: "auditorias",
                defaultValue: DateTime.Today.AddMonths(3),
                nullable: false
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fecha_vacunacion",
                table: "auditorias"
            );

            migrationBuilder.DropColumn(
                name: "fecha_vacunaproxima",
                table: "auditorias"
            );
        }
    }
}
