
class AlunoDAO : IDAO<Aluno>
{
    private CantinaSenacContext context = new CantinaSenacContext();
    public void Atualizar(Aluno aluno)
    {
        context.Alunos.Update(aluno);
        context.SaveChanges();
    }

    public void Cadastrar(Aluno aluno)
    {
        context.Alunos.Add(aluno);
        context.SaveChanges();
    }

    public void Excluir(Aluno aluno)
    {
        context.Alunos.Remove(aluno);
        context.SaveChanges();
    }

    public Aluno ListarPorId(int id)
    {
        Aluno? aluno = null;
        aluno = context.Alunos.FirstOrDefault(x => x.Id == id);
        return aluno;
    }

    public List<Aluno> ListarTodos()
    {
        return context.Alunos.ToList();
    }
}