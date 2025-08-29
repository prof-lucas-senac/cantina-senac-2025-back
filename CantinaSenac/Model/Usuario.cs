<<<<<<< HEAD
public abstract class Usuario
=======
abstract class Usuario
>>>>>>> master
{
    public int Id { get; set; }
    public string NomeDoUsuario { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Status { get; set; }
    public string Foto { get; set; }
<<<<<<< HEAD
    public List<Postagem> Postagens { get; set; }


    public abstract void Cadastrar();
    public abstract void Atualizar();
    public abstract void PublicarPostagem();
    public abstract void ComentarPostagem();
    public abstract void Logar();
}
=======
    // public List<Postagem> Postagens { get; set; }

    public abstract void Cadastrar();
    public abstract void Atualizar();
    public abstract void PublicarFeedback();
    public abstract void ComentarFeedback();
    public abstract void Logar();
}
>>>>>>> master
