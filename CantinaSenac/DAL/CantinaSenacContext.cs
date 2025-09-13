using System.Globalization;
using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    string stringConexao = "Server=localhost;Port=3306;DataBase=CantinaSenac;Uid=root;Pwd=xrtornado";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Usuario>().UseTpcMappingStrategy();
        builder.Entity<Postagem>().UseTpcMappingStrategy();
        builder.Entity<Aluno>().HasData(
            new Aluno()
            {
                Id = 1,
                NomeUsuario = "Joao",
                Email = "aluno@senac.com.br",
                Senha = "aluno",
                Status = 1
            }
        );
        builder.Entity<Feedback>().HasData(
            new Feedback()
            {
            Id = 1,
            Descricao = "Uma otima cantina, amei o pastel!!",
            dataPostagem = new DateTime(2025, 09, 12),
            UsuarioId = 1
    }
       );
    }

}