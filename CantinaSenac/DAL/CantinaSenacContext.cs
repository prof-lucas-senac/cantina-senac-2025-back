using Microsoft.EntityFrameworkCore;

public class CantinaSenacContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; } //interage com os DAO's
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)); // o serverversion.autodect serve para detectar autometicamente a versão do mysql que vai ser usada
    }
}