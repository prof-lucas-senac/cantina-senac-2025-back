using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{
    
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=root;";

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
                Email = "aluno@senac.br",
                Senha = "aluno",
                NomeDoUsuario = "Aluno",
                Status = 1
            }
        );
    }
}