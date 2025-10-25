public class AlunoController
{

    private AlunoDAO dao = new AlunoDAO();

    public List<Aluno> ListarAlunos()
    {
        return dao.ListarTodos();
    }

    public void Atualizar (Aluno aluno)
    {
        dao.Atualizar(aluno);

    }


    public void AdicionarAluno(Aluno aluno)
    {
        new AlunoDAO().Cadastrar(aluno);

        

    }

    public void ExcluirAluno(Aluno aluno)
    {

        dao.Excluir(aluno.Id);

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
            System.Console.WriteLine("Aluno não encontrado!");
            return null;
        }
    }

    
}