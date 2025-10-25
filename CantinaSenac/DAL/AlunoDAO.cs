
public class AlunoDAO : IDAO <Aluno>
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

    public void Excluir(Aluno aluno)
    {
        contexto.Alunos.Remove(aluno);
        contexto.SaveChanges();
    }

    public Aluno ListarPorId(int id)
    {
        contexto.FeedBacks.Find(id);
        return contexto.Alunos.Find(id);
        // pode ser usado FirstOrDefault(feedback => feedback.Id == id); para verificar se existe o id no banco
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}