public class Aluno : Usuario
{
    public Curso Curso { get; set; }
    public override string ComentarFeedback()
    {
        throw new NotImplementedException();
    }

    public override string logar()
    {
        throw new NotImplementedException();
    }

    public override string PublicarFeedback()
    {
        throw new NotImplementedException();
    }
}
