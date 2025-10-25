
class AlunoDAO : IDAO<Aluno>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();
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

    public void Excluir(int id)
    {
        var aluno = contexto.Alunos.Find(id);
        if (aluno != null)
        {
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
        }
    }

    public Aluno ListarPorId(int id)
    {
        Aluno aluno = null;
        aluno = contexto.Alunos.FirstOrDefault(a => a.Id == id); ;
        return contexto.Alunos.Find(id);
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}