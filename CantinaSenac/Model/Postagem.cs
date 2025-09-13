using System.Runtime.Versioning;

class Postagem
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataDePublicacao { get; set; }
    public Usuario Usuario { get; set; }
    public int UsuarioId { get; set; }
   // public List<Comentario> Comentarios = new List<Comentario>();
}