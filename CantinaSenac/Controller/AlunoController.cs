public class AlunoController
{
    private AlunoDAO dao = new AlunoDAO();
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
        Aluno alunos = dao.ListarTodos().FirstOrDefault(a => a.Id == aluno.Id);
        if (aluno != null)
        {
            dao.Excluir(aluno);
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
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

      public List<Aluno> ListarAlunos()
    {
        return new AlunoDAO().ListarTodos();
    }
    
    
}