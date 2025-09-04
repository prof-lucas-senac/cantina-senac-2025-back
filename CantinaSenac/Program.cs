// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        AlunoDAO.alunos.Add(new Aluno()
        {
            Id = 1,
            Email = "aluno@senac.br",
            Senha = "aluno"
        });

        LoginView.Exibir();
    }
}
