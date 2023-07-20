using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreWebApp.Migrations
{
    public partial class PFanPJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Pessoa",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Pessoa",
                maxLength: 14,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Pessoa");
        }
    }
}
