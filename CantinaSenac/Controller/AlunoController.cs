public class AlunoController
{
    public void AdicionarAluno(Aluno aluno)
    {
        AlunoDAO alunoDAO = new AlunoDAO();
        alunoDAO.Cadastrar(aluno);
    }
}