using System.Data.Common;
using Microsoft.EntityFrameworkCore;
class CantinaSenacContext : DbContext
{
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024";
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Usuario>().UseTpcMappingStrategy();
        builder.Entity<Postagem>().UseTpcMappingStrategy();
        builder.Entity<Aluno>().HasData(new Aluno()
        {
            Id = 1,
            Email = "aluno@senac.br",
            Senha = "aluno",
            NomeDoUsuario = "Aluno",
            Status = 1
        });
        builder.Entity<Feedback>().HasData(new Feedback()
        {
            Id = 1,
            DataPublicacao = new DateTime(2025, 9, 12, 21, 37, 0),
            UsuarioId = 1,
            Avaliacao = 5
        }
        );
    }
}