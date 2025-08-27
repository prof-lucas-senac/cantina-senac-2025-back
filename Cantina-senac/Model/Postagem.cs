namespace CantinaSenac.View
{

    public class Postagem
    {
        public string Id { get; set; }
        public string Descricao { get; set; }

        public DateTime DataPublicacao { get; set; }

        public Usuario Usuario { get; set; }

        public List<Comentario> Comentarios { get; set; }

    }
}