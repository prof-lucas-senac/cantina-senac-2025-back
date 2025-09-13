using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoChaveEstrangeiraIdUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Feedbacks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
