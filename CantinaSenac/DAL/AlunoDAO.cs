
class AlunoDAO : IDAO <Aluno>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();
    public void Atualizar(Aluno objeto)
    {
        contexto.Alunos.Update(objeto);
        contexto.SaveChanges();
    }

    public void Cadastrar(Aluno objeto)
    {
        contexto.Alunos.Add(objeto);
        contexto.SaveChanges();
    }

    public void Excluir(Aluno objeto)
    {
        contexto.Alunos.Remove(objeto);
        contexto.SaveChanges();
    }

    public Aluno Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}