using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CantinaSenac.DAL;

public class CantinaSenacContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024";
    protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
    {
        OptionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));

    }
     
}
