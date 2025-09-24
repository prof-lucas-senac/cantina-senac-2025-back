
class  AlunoDAO : IDAO<Aluno>
{

    private CantinaSenacContext contexto = new CantinaSenacContext();
   
   public void Atualizar(Aluno aluno)
    {
         throw new NotImplementedException();
    }
    public void Cadastrar(Aluno aluno)
    {
      
    }
    public void Excluir(Aluno objeto)
    {
        throw new NotImplementedException();
    }

    public Aluno Listar(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}