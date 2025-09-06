
public class AlunoDAO : IDAO <Aluno>
{
    private static List<Aluno> alunos = new List<Aluno>();

    public void Atualizar(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Aluno aluno)
    {
        alunos.Add(aluno);
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Aluno Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return alunos;
    }
}