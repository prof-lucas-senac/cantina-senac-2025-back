public class Aluno : Usuario
{
    public Curso curso { get; set; }

    public override void ComentarFeedBack()
    {
        throw new NotImplementedException();
    }

    public override void Logar()
    {
        throw new NotImplementedException();
    }

    public override void PublicarFeedBack()
    {
        throw new NotImplementedException();
    }
}