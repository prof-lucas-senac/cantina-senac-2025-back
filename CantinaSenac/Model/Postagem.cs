class Postagem
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPublicação { get; set; }
    public Usuario usuario { get; set; }
    public int UsuarioId { get; set; }
    //public List<Comentario> comentarios = new List<Comentario>();
    

}