public class AlunoController
{
    private AlunoDAO dao = new AlunoDAO();
    public void Adicionar(Aluno aluno)
    {
        dao.Cadastrar(aluno);
    }

    public List<Aluno> ListarAlunos()
    {
        return dao.ListarTodos();
    }

    public void ExcluirAluno(Aluno aluno)
    {
        dao.Excluir(aluno);
    }

    public void AtualizarAluno(Aluno aluno)
    {
        dao.Atualizar(aluno);
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