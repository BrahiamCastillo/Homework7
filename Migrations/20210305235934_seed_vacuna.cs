using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework7.Migrations
{
    public partial class seed_vacuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "vacunas",
                columns: new[] { "id", "cantidad", "marca" },
                values: new object[] { 1, 10, "Covid19" });

            migrationBuilder.InsertData(
                table: "vacunas",
                columns: new[] { "id", "cantidad", "marca" },
                values: new object[] { 2, 15, "Lepra" });

            migrationBuilder.InsertData(
                table: "vacunas",
                columns: new[] { "id", "cantidad", "marca" },
                values: new object[] { 3, 6, "AH1N1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "vacunas",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "vacunas",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "vacunas",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
