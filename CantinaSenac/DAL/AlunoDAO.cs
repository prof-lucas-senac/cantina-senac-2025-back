
class AlunoDAO : IDAO
{
    public static List<Aluno> alunos = new List<Aluno>();
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
        return null;
    }

    public List<Aluno> ListarTodos()
    {
        return alunos;
    }
}