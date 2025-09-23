<<<<<<< HEAD
class Feedback : Postagem
{
    
}
=======
public class Feedback : Postagem
{
    public int Id { get; set; }
    public string Comentario { get; set; }
    public DateTime DataPublicacao { get; set; }
    Usuario Usuario { get; set; }
    public void EnviarFeedback()
    { }
}
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
