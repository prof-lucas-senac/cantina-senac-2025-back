<<<<<<< HEAD
class Aluno : Usuario
{
    // public List<Curso> Cursos { get; set; } = new List<Curso>();

}
=======
public class Aluno : Usuario
{
    Curso Curso { get; set; }

    public override void Atualizar()
    {
        throw new NotImplementedException();
    }

    public override void Cadastrar()
    {
        throw new NotImplementedException();
    }

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
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
