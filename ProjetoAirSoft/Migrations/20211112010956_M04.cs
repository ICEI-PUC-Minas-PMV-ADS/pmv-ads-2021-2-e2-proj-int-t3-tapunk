using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAirSoft.Migrations
{
    public partial class M04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Equipes");

            migrationBuilder.RenameColumn(
                name: "TipodeEvento",
                table: "Equipes",
                newName: "NomedaEquipe");

            migrationBuilder.RenameColumn(
                name: "Endereço",
                table: "Equipes",
                newName: "Membro06");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Equipes",
                newName: "Membro05");

            migrationBuilder.AddColumn<string>(
                name: "HistoriadaEquipe",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Membro01",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Membro02",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Membro03",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Membro04",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HistoriadaEquipe",
                table: "Equipes");

            migrationBuilder.DropColumn(
                name: "Membro01",
                table: "Equipes");

            migrationBuilder.DropColumn(
                name: "Membro02",
                table: "Equipes");

            migrationBuilder.DropColumn(
                name: "Membro03",
                table: "Equipes");

            migrationBuilder.DropColumn(
                name: "Membro04",
                table: "Equipes");

            migrationBuilder.RenameColumn(
                name: "NomedaEquipe",
                table: "Equipes",
                newName: "TipodeEvento");

            migrationBuilder.RenameColumn(
                name: "Membro06",
                table: "Equipes",
                newName: "Endereço");

            migrationBuilder.RenameColumn(
                name: "Membro05",
                table: "Equipes",
                newName: "Descricao");

            migrationBuilder.AddColumn<int>(
                name: "Data",
                table: "Equipes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
