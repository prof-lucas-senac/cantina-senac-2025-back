using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoChaveEstrangeirausuario2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "FeedBack");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Comentario");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "FeedBack",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_usuarioId",
                table: "FeedBack",
                newName: "IX_FeedBack_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Comentario",
                newName: "UsuarioId");

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
                table: "FeedBack",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_UsuarioId",
                table: "FeedBack",
                newName: "IX_FeedBack_usuarioId");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Comentario",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Comentario_UsuarioId",
                table: "Comentario",
                newName: "IX_Comentario_usuarioId");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "FeedBack",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Comentario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
