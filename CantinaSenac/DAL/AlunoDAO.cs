
public class AlunoDAO : IDAO<Aluno>
{
    public CantinaSenacContext contexto = new CantinaSenacContext();
    private static List<Aluno> Alunos{ get; set; }
    public void Atualizar(Aluno aluno)
    {
        contexto.Alunos.Update(aluno);
        contexto.SaveChanges();
    }

    public void Cadastrar(Aluno aluno)
    {
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
        Aluno? aluno = null;
        aluno = contexto.Alunos.FirstOrDefault(
            aluno => aluno.Id == id
        );
        return aluno;
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}