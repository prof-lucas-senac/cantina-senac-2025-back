using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoChaveEstrangeiraIdUsuarioId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Postagem");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Feedbacks",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_usuarioId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Feedbacks",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_UsuarioId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_usuarioId");

            migrationBuilder.CreateTable(
                name: "Postagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataPostagem = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postagem", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_usuarioId",
                table: "Postagem",
                column: "usuarioId");
        }
    }
}
