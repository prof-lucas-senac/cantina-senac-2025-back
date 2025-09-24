
class AlunoDAO : IDAO<Aluno>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();
  //  private static List<Aluno> alunos = new List<Aluno>();
    public void Atualizar(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Aluno aluno)
    {
    //    alunos.Add(aluno);
    }

    public void Excluir(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public Aluno Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList() ;
    }
}