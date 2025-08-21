public class Postagem
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPublicação { get; set; }
    public List<Comentario> comentarios = new List<Comentario>();

    // usuario recebe de usuario Usuario : Usuario (classe abstrata)
}