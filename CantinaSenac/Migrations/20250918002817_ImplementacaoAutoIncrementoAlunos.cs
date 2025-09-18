using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class ImplementacaoAutoIncrementoAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Postagem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagem",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UsuarioId",
                table: "Feedbacks",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagem");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_UsuarioId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Postagem");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Feedbacks");
        }
    }
}
