public class Comentario
{
    public int Id { get; set; }
    public string Texto { get; set; }
    public DateTime DataComentario { get; set; }
     Usuario Usuario { get; set; }
    Postagem Postagem { get; set; }
}
