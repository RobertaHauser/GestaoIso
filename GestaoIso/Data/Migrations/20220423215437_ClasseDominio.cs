using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoIso.Data.Migrations
{
    public partial class ClasseDominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dominio",
                columns: table => new
                {
                    DominioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: true),
                    Tabela = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dominio", x => x.DominioId);
                });

            migrationBuilder.InsertData(
                table: "Dominio",
                columns: new[] { "DominioId", "Descricao", "Ordem", "Tabela" },
                values: new object[,]
                {
                    { 1, "Analfabeto", null, "Educacao" },
                    { 2, "Alfabetizado", null, "Educacao" },
                    { 3, "Fundamental", null, "Educacao" },
                    { 4, "Médio", null, "Educacao" },
                    { 5, "Superior", null, "Educacao" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dominio");
        }
    }
}
