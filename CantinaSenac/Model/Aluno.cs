class Aluno : Usuario
{
<<<<<<< HEAD
    public Curso curso { get; set; }

=======
    // public List<Curso> Cursos { get; set; } = new List<Curso>();
>>>>>>> master
    public override void Atualizar()
    {
        throw new NotImplementedException();
    }

    public override void Cadastrar()
    {
        throw new NotImplementedException();
    }

<<<<<<< HEAD
    public override void ComentarPostagem()
=======
    public override void ComentarFeedback()
>>>>>>> master
    {
        throw new NotImplementedException();
    }

    public override void Logar()
    {
        throw new NotImplementedException();
    }

<<<<<<< HEAD
    public override void PublicarPostagem()
=======
    public override void PublicarFeedback()
>>>>>>> master
    {
        throw new NotImplementedException();
    }
}