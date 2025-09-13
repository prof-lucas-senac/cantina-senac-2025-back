
class AlunoDAO : IDAO<Aluno>
{

    private CantinaSenacContext contexto = new CantinaSenacContext();
    // public static List<Aluno> alunos = new List<Aluno>();

    public void Atualizar(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Aluno aluno)
    {
        // aluno.Id = alunos.Count + 1;
        // alunos.Add(aluno);
        contexto.Alunos.Add(aluno);
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Aluno listar(int id)
    {
        
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        // return alunos;
        return contexto.Alunos.ToList();
    }
}