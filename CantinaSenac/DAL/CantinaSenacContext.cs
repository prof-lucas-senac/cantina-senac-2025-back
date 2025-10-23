using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{
    
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=1234;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
       builder.Entity<Usuario>().HasMany(a => a.Postagens)
            .WithOne(f => f.Usuario)
            .HasForeignKey(f => f.UsuarioId);
            builder.Entity<Aluno>().ToTable("Alunos");

        builder.Entity<Aluno>().HasData(
            new Aluno()
            {
                Id = 1,
                NomeDoUsuario = "Ric",
                Email = "aluno@senac.com.br",
                Senha = "aluno",
                Status = 1
            }
        );
     //   builder.Entity<Feedback>().HasData(
      //      new Feedback()
      //      {
      //          Id = 1,
       //         Descricao = "Ótimo atendimento!",
      //          DataPublicacao = new DateTime(2025, 09, 17),
       //         UsuarioId = 1
     //       }
      //  );
    }
    
}