using System.Data.Common;

class AlunoController
{
    public void Cadastrar(Aluno aluno)
    {
        new AlunoDAO().Cadastrar(aluno);
    }

}