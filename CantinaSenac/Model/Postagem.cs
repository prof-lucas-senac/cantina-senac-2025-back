public class Postagem
{
    public int Id { get; set; }
    public string decricao { get; set; }
    public DateTime DataPublicacao { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    //public List<Comentario> comentarios { get; set; }
}