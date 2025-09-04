
class  AlunoDAO : IDAO
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
    public string Excluir(int id)
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