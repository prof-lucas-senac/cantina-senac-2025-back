abstract class Usuario
{
    public int Id { get; set; }
    public string NomeUsuario { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Status { get; set; }
    public string Foto { get; set; }
    public List<Postagem> Postagens { get; set; }

    public abstract void Cadastrar();
    public abstract void Atualizar();
    public abstract void PublicarFeedback();
    public abstract void ComentarFeedback();
    public abstract void Logar();
}