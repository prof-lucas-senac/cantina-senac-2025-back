
public abstract class Usuario
{
    public int Id { get; set; }
    public string NomeUsuario { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Status { get; set; }
    public string foto { get; set; }
    public List<Postagem> Postagens { get; set; }

    public Usuario() { }

    public abstract void Cadastrar();

    public abstract void Atualizar();

    public abstract void publicarFeedback();

    public abstract void comentarFeedback();
    
    public abstract void logar();
}