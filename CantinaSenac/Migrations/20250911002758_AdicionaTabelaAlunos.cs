using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaSenac.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTabelaAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Curso_cursoId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Postagem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Alunos");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_cursoId",
                table: "Alunos",
                newName: "IX_Alunos_cursoId");

            migrationBuilder.AlterColumn<int>(
                name: "cursoId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Curso_cursoId",
                table: "Alunos",
                column: "cursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Curso_cursoId",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_cursoId",
                table: "Usuario",
                newName: "IX_Usuario_cursoId");

            migrationBuilder.AlterColumn<int>(
                name: "cursoId",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Postagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostagemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postagem_Postagem_PostagemId",
                        column: x => x.PostagemId,
                        principalTable: "Postagem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Postagem_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_PostagemId",
                table: "Postagem",
                column: "PostagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_usuarioId",
                table: "Postagem",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Curso_cursoId",
                table: "Usuario",
                column: "cursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
