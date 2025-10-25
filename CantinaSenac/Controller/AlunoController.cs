public class AlunoController
{
    private AlunoDAO dao = new AlunoDAO();
    public void AdicionarAluno(Aluno aluno)
    {
        dao.Cadastrar(aluno);
    }

    public void RemoverAluno(Aluno aluno)
    {
        dao.Excluir(aluno);
    }
    public void AtualizarAlunos(Aluno aluno)
    {
        dao.Atualizar(aluno);
    }

    public List<Aluno> MostrarAlunos()
    {
        return new AlunoDAO().ListarTodos();
        
    }
    public Aluno ListarPorId(int id)
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