
class AlunoDAO : IDAO<Aluno>
{
    private static List<Aluno> alunos = new List<Aluno>();
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

    public void Excluir(Aluno aluno)
    {
        contexto.Alunos.Remove(aluno);
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
        return alunos;
    }
    
}