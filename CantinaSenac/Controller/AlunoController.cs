public class AlunoController
{

    public List<Aluno> Listar()
    {
        AlunoDAO alunoDAO = new AlunoDAO();
        return alunoDAO.ListarTodos();
    }

    public Aluno ListarPorId(int id)
    {
        AlunoDAO alunoDAO = new AlunoDAO();
            return alunoDAO.ListarPorId(id);
    }
    public void AdicionarAluno(Aluno aluno)
    {
        AlunoDAO alunoDAO = new AlunoDAO();
        alunoDAO.Cadastrar(aluno);
    }
    public void DeletarAluno(Aluno aluno)
    {
        AlunoDAO alunoDAO = new AlunoDAO();
        alunoDAO.Excluir(aluno);
    }
    public void AtualizarAluno(Aluno aluno, string novoNome, string novoEmail, string novaSenha, int novoStatus)
    {
        AlunoDAO alunoDAO = new AlunoDAO();

        if (aluno != null)
        {
            aluno.NomeUsuario = novoNome;
            aluno.Email = novoEmail;
            aluno.Senha = novaSenha;
            aluno.Status = novoStatus;
            alunoDAO.Atualizar(aluno);
        }
    }

}