public class Feedback : Postagem
{
    public int Nota { get; set; }

    public Feedback(string descricao, int nota, Usuario usuario)
    {
        this.Descricao = descricao;
        this.Nota = nota;
        this.usuario = usuario;
        this.DataPublicacao = DateTime.Now;
        this.Comentarios = new List<Comentario>();
    }
}