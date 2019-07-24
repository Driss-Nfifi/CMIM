using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMIM.Migrations
{
    public partial class doss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dateLunette",
                table: "Dossiers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateLunette",
                table: "Dossiers");
        }
    }
}
