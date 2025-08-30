
class AlunoDAO : IDAO
{
    public static List<Aluno> alunos = new List<Aluno>();
    public void Atualizar()
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Aluno aluno)
    {
        alunos.Add(aluno);

    }

    public void Excluir()
    {
        throw new NotImplementedException();
    }

    public Aluno Listar(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return alunos;
    }
}