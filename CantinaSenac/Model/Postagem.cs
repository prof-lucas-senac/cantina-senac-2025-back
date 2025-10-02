// Classe abstrata que representa uma postagem genérica no sistema
// Pode ser herdada por tipos específicos de postagem, como Feedback, Aviso, etc.
abstract class Postagem
{
    // Identificador único da postagem
    public int Id { get; set; }

    // Texto ou conteúdo principal da postagem
    public string? Descricao { get; set; }

    // Data e hora em que a postagem foi publicada
    public DateTime DataPublicacao { get; set; } 

    // Referência ao usuário que criou a postagem (propriedade de navegação)
    public Usuario? Usuario { get; set; }

    // Chave estrangeira que relaciona a postagem ao usuário
    public int UsuarioId { get; set; }

    // Lista de comentários associados à postagem (comentado por enquanto)
    // public List<Comentario> Comentarios { get; set; }
}
