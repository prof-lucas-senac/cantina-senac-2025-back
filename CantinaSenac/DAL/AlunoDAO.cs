
public class AlunoDAO : IDAO <Aluno>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();

    public void Atualizar(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Aluno aluno)
    {
        //contexto.Add(aluno);
    }

    public void Excluir(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public Aluno ListarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}