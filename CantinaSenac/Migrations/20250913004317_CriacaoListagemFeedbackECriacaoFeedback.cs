using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoListagemFeedbackECriacaoFeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Descricao", "UsuarioId", "dataPostagem" },
                values: new object[] { 1, "Uma otima cantina, amei o pastel!!", 1, new DateTime(2025, 9, 12, 21, 43, 16, 765, DateTimeKind.Local).AddTicks(5398) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
