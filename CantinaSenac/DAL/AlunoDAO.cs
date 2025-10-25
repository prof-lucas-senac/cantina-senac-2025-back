
class AlunoDAO : IDAO<Aluno>
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

    public Aluno ListarPorId(int id)
    {
        Aluno? aluno = null;
        aluno = contexto.Alunos.FirstOrDefault(
            aluno => aluno.Id == id
            );
        if (aluno != null)
        {
            return aluno;

        }
        else
        {
            return null;
        }
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}