using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FC_Imobiliaria.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroQuartos = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inquilinos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    QuantImoveis = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquilinos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InquilinoImoveis",
                columns: table => new
                {
                    InquilinoID = table.Column<int>(type: "int", nullable: false),
                    ImovelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InquilinoImoveis", x => new { x.InquilinoID, x.ImovelID });
                    table.ForeignKey(
                        name: "FK_InquilinoImoveis_Imoveis_ImovelID",
                        column: x => x.ImovelID,
                        principalTable: "Imoveis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InquilinoImoveis_Inquilinos_InquilinoID",
                        column: x => x.InquilinoID,
                        principalTable: "Inquilinos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InquilinoImoveis_ImovelID",
                table: "InquilinoImoveis",
                column: "ImovelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InquilinoImoveis");

            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropTable(
                name: "Inquilinos");
        }
    }
}
