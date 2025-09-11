using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{

    public DbSet<Aluno> Alunos { get; set; }
    string stringConexao = "Server=localhost;Port=3306;DataBase=CantinaSenac;Uid=root;Pwd=xrtornado";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

}