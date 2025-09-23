<<<<<<< HEAD
abstract class Usuario
=======
public abstract class Usuario
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
{
    public int Id { get; set; }
    public string NomeDoUsuario { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Status { get; set; }
<<<<<<< HEAD
    public string? Foto { get; set; }
    public List<Postagem> Postagens { get; set; }
=======
    public string Foto { get; set; }
    public List<Postagem> Postagens { get; set; }

    public abstract void Cadastrar();
    public abstract void Atualizar();
    public abstract void PublicarFeedback();
    public abstract void ComentarFeedback();
    public abstract void Logar();

>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
}