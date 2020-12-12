using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjBiblio.Infrastructure.Data.Migrations
{
    public partial class UpdateTableLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Livro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Edicao",
                table: "Livro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Editora",
                table: "Livro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Paginas",
                table: "Livro",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Edicao",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Editora",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Paginas",
                table: "Livro");
        }
    }
}
