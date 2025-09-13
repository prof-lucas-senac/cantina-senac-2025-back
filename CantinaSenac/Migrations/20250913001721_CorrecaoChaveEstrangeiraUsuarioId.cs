using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoChaveEstrangeiraUsuarioId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Postagem");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Feedbacks");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Postagem",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagem_usuarioId",
                table: "Postagem",
                newName: "IX_Postagem_UsuarioId");

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
                table: "Postagem",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagem",
                newName: "IX_Postagem_usuarioId");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Feedbacks",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_UsuarioId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_usuarioId");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Postagem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
