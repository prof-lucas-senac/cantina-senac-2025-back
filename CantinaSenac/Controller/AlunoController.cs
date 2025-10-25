public class AlunoController
{
    private AlunoDAO dao = new AlunoDAO();
    public List<Aluno> ListarAlunos()
    {
        return new AlunoDAO().ListarTodos();
    }

    public void PostarAluno(Aluno aluno)
    {
        dao.Cadastrar(aluno);
    }


    public void AtualizarAlunos(Aluno aluno)
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
    
    public void ExcluirAluno(Aluno aluno)
    {
        dao.Excluir(aluno);
    }
}