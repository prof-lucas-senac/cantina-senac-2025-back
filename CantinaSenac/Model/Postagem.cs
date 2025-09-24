<<<<<<< HEAD
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;

abstract class Postagem
=======
public class Postagem
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
=======
using System.ComponentModel.DataAnnotations;

abstract class Postagem
>>>>>>> master
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Usuario Usuario { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
    public int UsuarioId { get; set; }
    // public List<Comentario> Comentarios { get; set; }
}
=======
    public List<Comentario> Comentarios { get; set; }

}
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
=======
    public int UsuarioId { get; set; }
    // public List<Comentario> Comentarios { get; set; }
}
>>>>>>> master
