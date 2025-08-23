public class Feedback : Postagem
{
    public int Id { get; set; }
    public string Comentario { get; set; }
    public DateTime DataPublicacao { get; set; }
    Usuario Usuario { get; set; }
    public void EnviarFeedback()
    { }
}
