public class AlunoController
{
    public void AdicionarAluno()
    {
        AlunoDAO alunoDAO = new AlunoDAO();
        Aluno aluno = new Aluno();

        Console.Write("email: "); aluno.Email = Console.ReadLine();
        Console.Write("senha: "); aluno.Senha = Console.ReadLine();

        alunoDAO.Cadastrar(aluno);
    }
}