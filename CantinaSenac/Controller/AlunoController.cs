public class AlunoController
{
    private AlunoDAO dao = new AlunoDAO();
     
      public List<Aluno> ListarAluno()
    {
        return new AlunoDAO().ListarTodos();
    }
    public void AdicionarAluno(Aluno aluno)
    {
        new AlunoDAO().Cadastrar(aluno);
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
