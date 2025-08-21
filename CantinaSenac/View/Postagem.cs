public class Postagem
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Usuario usuario { get; set; }
    public List<Comentario> comentarios { get; set; }
}