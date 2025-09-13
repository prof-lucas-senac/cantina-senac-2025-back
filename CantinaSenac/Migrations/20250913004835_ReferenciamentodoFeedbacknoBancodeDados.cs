using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class ReferenciamentodoFeedbacknoBancodeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Feedbacks",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Avaliacao", "DataPublicacao", "Descricao", "UsuarioId" },
                values: new object[] { 1, 5, new DateTime(2025, 9, 12, 21, 37, 0, 0, DateTimeKind.Unspecified), null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Feedbacks",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
