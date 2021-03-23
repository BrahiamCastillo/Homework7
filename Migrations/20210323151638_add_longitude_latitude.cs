using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework7.Migrations
{
    public partial class add_longitude_latitude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Double>(
                name: "latitude",
                table: "provincias",
                nullable: false
            );

            migrationBuilder.AddColumn<Double>(
                name: "longitude",
                table: "provincias",
                nullable: false
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "latitude",
                table: "provincias");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "provincias");
        }
    }
}
