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