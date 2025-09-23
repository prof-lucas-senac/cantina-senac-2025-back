using Microsoft.EntityFrameworkCore;
class CantinaSenacContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder Builder)
    {

        Builder.Entity<Aluno>().ToTable("Alunos");

        Builder.Entity<Usuario>().HasMany(a => a.Postagens)
            .WithOne(f => f.Usuario)
            .HasForeignKey(f => f.UsuarioId);

        Builder.Entity<Aluno>().HasData(
            new Aluno()
            {
                Id = 1,
                NomeDoUsuario = "Alan",
                Email = "alan",
                Senha = "123",
                Status = 1
            }
        );
    }
}