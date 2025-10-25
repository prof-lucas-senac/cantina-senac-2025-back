public class AlunoController
{
    private AlunoDAO alunoDAO = new AlunoDAO();
    public void AdicionarAluno(Aluno aluno)
    {
        AlunoDAO alunoDAO = new AlunoDAO();
        alunoDAO.Cadastrar(aluno);
    }
    public void AlterarAluno(Aluno aluno)
    {
        alunoDAO.Atualizar(aluno);
    }
    public void ExcluirAluno(Aluno aluno)
    {
        alunoDAO.Excluir(aluno);
    }
    public List<Aluno> ListarTodosAlunos()
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();
        return alunos;
    }
    public Aluno ListarPorId(int id)
    {
        Aluno aluno = alunoDAO.ListarPorId(id);

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