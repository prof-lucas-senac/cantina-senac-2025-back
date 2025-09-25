// Importa o namespace necessário para usar o Entity Framework Core
using Microsoft.EntityFrameworkCore;

// Classe que representa o contexto do banco de dados da aplicação Cantina SENAC
class CantinaSenacContext : DbContext
{
    // Define a tabela de Alunos no banco como um conjunto de entidades
    public DbSet<Aluno> Alunos { get; set; }

    // Define a tabela de Feedbacks no banco como um conjunto de entidades
    public DbSet<Feedback> Feedbacks { get; set; }

    // String de conexão com o banco de dados MySQL
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenac;Uid=root;Pwd=S&nac2024";

    // Configura o provedor de banco de dados e a string de conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Usa o MySQL como banco de dados e detecta automaticamente a versão do servidor
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    // Configurações adicionais do modelo (mapeamento de entidades e dados iniciais)
    protected override void OnModelCreating(ModelBuilder Builder)
    {
        // Mapeia explicitamente a entidade Aluno para a tabela "Alunos"
        Builder.Entity<Aluno>().ToTable("Alunos");

        // Configura o relacionamento entre Usuario e Postagens:
        // Um usuário pode ter várias postagens, cada postagem pertence a um usuário
        Builder.Entity<Usuario>().HasMany(a => a.Postagens)
            .WithOne(f => f.Usuario)
            .HasForeignKey(f => f.UsuarioId);

        // Insere um registro inicial na tabela Alunos com dados fictícios
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
