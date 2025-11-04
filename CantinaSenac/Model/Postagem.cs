<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;

>>>>>>> master
public abstract class Postagem
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataPublicacao { get; set; }
<<<<<<< HEAD
    public Usuario? Usuario { get; set; }
    public int UsuarioId { get; set; }
    
=======
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
>>>>>>> master
    // public List<Comentario> Comentarios { get; set; }
}