using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BaraTIao.Migrations
{
    public partial class VersaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "BaraTIao");

            migrationBuilder.CreateTable(
                name: "Bairros",
                schema: "BaraTIao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                schema: "BaraTIao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(maxLength: 100, nullable: false),
                    BairroId = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lojas_Bairros_BairroId",
                        column: x => x.BairroId,
                        principalSchema: "BaraTIao",
                        principalTable: "Bairros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lojas_BairroId",
                schema: "BaraTIao",
                table: "Lojas",
                column: "BairroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lojas",
                schema: "BaraTIao");

            migrationBuilder.DropTable(
                name: "Bairros",
                schema: "BaraTIao");
        }
    }
}
