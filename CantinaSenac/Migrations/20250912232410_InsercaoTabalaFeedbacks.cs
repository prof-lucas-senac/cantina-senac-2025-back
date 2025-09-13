using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoTabalaFeedbacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Comentario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "dataPublicacao",
                table: "Comentario",
                newName: "DataPublicacao");

            migrationBuilder.RenameIndex(
                name: "IX_Comentario_usuarioId",
                table: "Comentario",
                newName: "IX_Comentario_UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Comentario",
                newName: "usuarioId");

            migrationBuilder.RenameColumn(
                name: "DataPublicacao",
                table: "Comentario",
                newName: "dataPublicacao");

            migrationBuilder.RenameIndex(
                name: "IX_Comentario_UsuarioId",
                table: "Comentario",
                newName: "IX_Comentario_usuarioId");
        }
    }
}
