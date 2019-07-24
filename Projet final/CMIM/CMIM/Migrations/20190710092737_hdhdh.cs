using Microsoft.EntityFrameworkCore.Migrations;

namespace CMIM.Migrations
{
    public partial class hdhdh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "site",
                table: "employees",
                newName: "Site");

            migrationBuilder.AddColumn<string>(
                name: "matriculecmim",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "matriculecmim",
                table: "Conjoint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "matriculecmim",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "matriculecmim",
                table: "Conjoint");

            migrationBuilder.RenameColumn(
                name: "Site",
                table: "employees",
                newName: "site");
        }
    }
}
