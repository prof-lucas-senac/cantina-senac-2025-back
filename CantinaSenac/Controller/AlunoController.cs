public class AlunoController
{
    private AlunoDAO dao = new AlunoDAO();
    public List<Aluno> ListarAlunos()
    {
        return dao.ListarTodos();
    }
    public void AdicionarAluno(Aluno aluno)
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

    public Aluno? ListarPorId(int id)
    {
        Aluno aluno = dao.ListarPorId(id);
        if (aluno != null)
        {
            return aluno;
        }
        else
        {
            return null;
        }
    }
}