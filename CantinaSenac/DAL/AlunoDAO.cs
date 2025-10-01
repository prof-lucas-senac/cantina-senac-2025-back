class AlunoDAO : IDAO<Aluno>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();

    public void Cadastrar(Aluno aluno)
    {
        contexto.Alunos.Add(aluno);
        contexto.SaveChanges();
    }

    public void Atualizar(Aluno aluno)
    {
        contexto.Alunos.Update(aluno);
        contexto.SaveChanges();
    }

    public void Excluir(Aluno aluno)
    {
        contexto.Alunos.Remove(aluno);
        contexto.SaveChanges();
    }

    public void Remover(int id)
    {
        var aluno = contexto.Alunos.FirstOrDefault(a => a.Id == id);
        if (aluno != null)
        {
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
            Console.WriteLine($"\nAluno com ID {id} removido do banco de dados.");
        }
        else
        {
            Console.WriteLine($"\nAluno com ID {id} não encontrado no banco de dados.");
        }
    }

}