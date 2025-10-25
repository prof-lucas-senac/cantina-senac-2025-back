
class AlunoDAO : IDAO<Aluno>
{

    private CantinaSenacContext contexto = new CantinaSenacContext();
    // public static List<Aluno> alunos = new List<Aluno>();

    public void Atualizar(Aluno aluno)
    {
        contexto.Alunos.Update(aluno);
        contexto.SaveChanges();
    }

    public void Cadastrar(Aluno aluno)
    {
        // aluno.Id = alunos.Count + 1;
        // alunos.Add(aluno);
        contexto.Alunos.Add(aluno);
        contexto.SaveChanges();
    }

    public void Excluir(Aluno objeto)
    {
        contexto.Alunos.Remove(objeto);
        contexto.SaveChanges();
    }

    public Aluno ListarPorId(int id)
    {
        Aluno aluno = null;
        aluno = contexto.Alunos.FirstOrDefault(aluno => aluno.Id == id);
        return contexto.Alunos.Find(id);
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
} 