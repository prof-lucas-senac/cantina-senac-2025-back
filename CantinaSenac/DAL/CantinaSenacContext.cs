using Microsoft.EntityFrameworkCore;
class CantinaSenacContext : DbContext
{
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024";
    public DbSet<Aluno> Alunos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao,ServerVersion.AutoDetect(stringConexao));
    }
}