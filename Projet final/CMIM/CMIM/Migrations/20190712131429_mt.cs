using Microsoft.EntityFrameworkCore.Migrations;

namespace CMIM.Migrations
{
    public partial class mt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Devis_D",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtCadre_L",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtGi_L",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtPharmacie_M",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtProthese_D",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtSoins_D",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtVisite_L",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MtVisite_M",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Mt_analyse",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Mt_radio",
                table: "Dossiers",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Devis_D",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtCadre_L",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtGi_L",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtPharmacie_M",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtProthese_D",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtSoins_D",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtVisite_L",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "MtVisite_M",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "Mt_analyse",
                table: "Dossiers");

            migrationBuilder.DropColumn(
                name: "Mt_radio",
                table: "Dossiers");
        }
    }
}
