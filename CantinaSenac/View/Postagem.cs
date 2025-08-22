public class Postagem
{
    public int IdPostagem { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPubicacao { get; set; }
    public Usuario usaurio { get; set; }
    public List<Comentario> Comentarios { get; set; }
}