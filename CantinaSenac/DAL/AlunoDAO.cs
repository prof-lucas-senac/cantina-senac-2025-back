
<<<<<<< HEAD
class AlunoDAO : IDAO
=======
class AlunoDAO : IDAO<Aluno>
>>>>>>> master
{
    private CantinaSenacContext contexto = new CantinaSenacContext();
    public void Atualizar(Aluno aluno)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Aluno aluno)
    {
<<<<<<< HEAD
        throw new NotImplementedException();
    }

    public void Excluir(int id)
=======
        // alunos.Add(aluno);
    }

    public void Excluir(Aluno objeto)
>>>>>>> master
    {
        throw new NotImplementedException();
    }

<<<<<<< HEAD
    public Aluno Listar(int id)
=======
    public Aluno ListarPorId(int id)
>>>>>>> master
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarTodos()
    {
        return contexto.Alunos.ToList();
    }
}