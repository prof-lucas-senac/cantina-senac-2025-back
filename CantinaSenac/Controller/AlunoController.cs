class AlunoController : FeedbackController
{
    public void Adicionar(Aluno aluno)
    {
        new AlunoDAO().Cadastrar(aluno);
    }
}