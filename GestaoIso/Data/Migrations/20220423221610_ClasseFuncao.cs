using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoIso.Data.Migrations
{
    public partial class ClasseFuncao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcao",
                columns: table => new
                {
                    FuncaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DominioIdEducacao = table.Column<int>(type: "int", nullable: false),
                    Treinamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroResp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CadastroData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevisaoResp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisaoData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AprovacaoStatus = table.Column<bool>(type: "bit", nullable: false),
                    AprovacaoResp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprovacaoData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcao", x => x.FuncaoId);
                    table.ForeignKey(
                        name: "FK_Funcao_Dominio_DominioIdEducacao",
                        column: x => x.DominioIdEducacao,
                        principalTable: "Dominio",
                        principalColumn: "DominioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcao_Cargo",
                table: "Funcao",
                column: "Cargo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcao_DominioIdEducacao",
                table: "Funcao",
                column: "DominioIdEducacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcao");
        }
    }
}
