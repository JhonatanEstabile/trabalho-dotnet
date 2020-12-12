using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjBiblio.Infrastructure.Data.Migrations
{
    public partial class CreateTableMarketing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marketing",
                columns: table => new
                {
                    MarketingID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(nullable: true),
                    DataInicio = table.Column<string>(nullable: true),
                    DataFim = table.Column<string>(nullable: true),
                    PercentualDesconto = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marketing", x => x.MarketingID);
                });

            migrationBuilder.CreateTable(
                name: "LivroMarketing",
                columns: table => new
                {
                    LivroID = table.Column<int>(nullable: false),
                    MarketingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroMarketing", x => new { x.LivroID, x.MarketingID });
                    table.ForeignKey(
                        name: "FK_LivroMarketing_Livro_LivroID",
                        column: x => x.LivroID,
                        principalTable: "Livro",
                        principalColumn: "LivroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivroMarketing_Marketing_MarketingID",
                        column: x => x.MarketingID,
                        principalTable: "Marketing",
                        principalColumn: "MarketingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivroMarketing_MarketingID",
                table: "LivroMarketing",
                column: "MarketingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivroMarketing");

            migrationBuilder.DropTable(
                name: "Marketing");
        }
    }
}
