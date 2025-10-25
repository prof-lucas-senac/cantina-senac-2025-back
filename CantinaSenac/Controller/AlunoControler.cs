public static class AlunoController
{
    private static AlunoDAO alunoDAO = new AlunoDAO();
    public static void Adicionar(Aluno aluno)
    {
        alunoDAO.Cadastrar(aluno);
    }
    public static void Remover(Aluno aluno)
    {
        alunoDAO.Excluir(aluno);
    }
    public static void Editar(Aluno aluno)
    {
        alunoDAO.Atualizar(aluno);
    }
    public static Aluno? ObterPorId(int id)
    {
        Aluno aluno = alunoDAO.ListarPorId(id);
        if (aluno != null)
        {
            return aluno;
        }
        else
        {
            return null;
        }
    }
    public static List<Aluno> ListarAlunos()
    {
        return alunoDAO.ListarTodos();
    }
}
