public abstract class Usuario
{
    public int Id { get; set; }
    public string NomeDoUsuario { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Status { get; set; }
    public string Foto { get; set; }
    // public List<Postagem> Postagens { get; set; }

    public abstract void Cadastrar();
    public abstract void Atualizar();
    public abstract void PublicarFeedBack();
    public abstract void ComentarFeedBack();
    public abstract void Logar();

}