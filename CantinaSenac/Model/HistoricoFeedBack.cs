// Classe que representa o histórico de um feedback publicado no sistema
// Pode ser usada para registrar ações passadas, como edições, exclusões ou visualizações
class HistoricoFeedBack
{
    // Data e hora em que o feedback foi publicado ou registrado no histórico
    public DateTime DataPublicacao { get; set; }

    // Referência à postagem original associada ao histórico (propriedade de navegação)
    public Postagem postagem { get; set; }

    // Referência ao usuário que publicou ou interagiu com o feedback (propriedade de navegação)
    public Usuario usuario { get; set; }
}
