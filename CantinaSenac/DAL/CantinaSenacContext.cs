using System.ComponentModel.Design.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
class CantinaSenacContext : DbContext
{

    public DbSet<Aluno> Alunos { get; set; }

    public DbSet<Feedback> Feedbacks { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024;";


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Usuario>().UseTpcMappingStrategy();
        builder.Entity<Postagem>().UseTpcMappingStrategy();

        builder.Entity<Aluno>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        builder.Entity<Aluno>().HasData(
            new Aluno()
            {
                Id = 1,
                Email = "aluno@senac.br",
                Senha = "aluno",
                NomeDoUsuario = "Aluno",
                Status = 1
            }
        );

        builder.Entity<Feedback>().HasData(
       new Feedback()
       {
           Id = 1,
           Descricao = "aluno@senac.br",
           DataPublicacao = new DateTime(2025, 09, 12),
           UsuarioId = 1
       }
   );
    }
} 

// toda alteração tem que ter migration
