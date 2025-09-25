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
 
    public void Excluir(Aluno objeto)
    {
        contexto.Alunos.Remove(objeto);
        contexto.SaveChanges();
    }
 
    public Aluno Listar(int id)
    {
       return contexto.Alunos.FirstOrDefault(a => a.Id == id);
    }
 
    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}