using System.Diagnostics.CodeAnalysis;

public class AlunoControler
{
    private AlunoDAO dao = new AlunoDAO();

    public List<Aluno> ListarAlunos()
    {
        return new AlunoDAO().ListarTodos();
    }

    public void CadastrarAluno(Aluno aluno)
    {
        dao.Cadastrar(aluno);

    }

    public void AtualizarAluno(Aluno aluno)
    {
        dao.Atualizar(aluno);
    }

    public void ExcluirAluno(Aluno aluno)
    {
        dao.Excluir(aluno);
    }
}