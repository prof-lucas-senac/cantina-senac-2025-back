public abstract class Postagem

{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPubicacao { get; set; }
    public Usuario Usuario { get; set; }
    public int UsuarioId { get; set; }
    public List<Comentario> Comentarios { get; set; }
    
}