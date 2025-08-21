public class Postagem
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime dataPostagem { get; set; }
    public Usuario usuario { get; set; }
    public List<Comentario> comentarios { get; set; }

    public Postagem() { }




}