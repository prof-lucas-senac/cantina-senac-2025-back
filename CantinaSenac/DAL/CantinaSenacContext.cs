using Microsoft.EntityFrameworkCore;

public class CantinaSenacContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; } //interage com os DAO's
    public DbSet<FeedBack> FeedBacks { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)); // o serverversion.autodect serve para detectar automaticamente a versão do mysql que vai ser usada
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Usuario>().HasMany(a => a.Postagens) //define a chave primaria
            .WithOne(f => f.Usuario) //define o relacionamento
            .HasForeignKey(f => f.UsuarioId); //define a chave estrangeira

        builder.Entity<Aluno>().HasData //hasdata serve para inserir novo aluno
        (
            new Aluno()
            {
                Id = 1,
                NomeDoUsuario = "aluno",
                Email = "abc",
                Senha = "teste",
                Status = 1
            }
        );
    }
}