class AlunoController
{

    public void Adicionar(Aluno aluno)
    {
        new AlunoDAO().Cadastrar(aluno);
    }
}