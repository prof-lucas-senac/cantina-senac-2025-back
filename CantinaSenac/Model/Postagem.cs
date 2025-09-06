public class Postagem
{
    public int IdPostagem { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPubicacao { get; set; }
    public Usuario usuario { get; set; }
    public List<Comentario> Comentarios { get; set; }

    public Postagem(string descricao, Usuario usuarioComentando)
    {
        Descricao = descricao;
        usuario = usuarioComentando;
    }

    
   
}