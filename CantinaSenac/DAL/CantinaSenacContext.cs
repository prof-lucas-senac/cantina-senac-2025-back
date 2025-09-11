using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;UId=root;Pwd=S&nac2024";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }
}