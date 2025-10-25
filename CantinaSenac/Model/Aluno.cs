public class Aluno : Usuario
{
    
    public List<Curso> Cursos { get; set; } = new List<Curso>();
    public override void ComentarFeedback()
    {
        throw new NotImplementedException();
    }

    public override void Logar()
    {
        throw new NotImplementedException();
    }

    public override void PublicarFeedback()
    {
        throw new NotImplementedException();
    }
}