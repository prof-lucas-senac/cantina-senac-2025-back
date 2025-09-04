// See https://aka.ms/new-console-template for more information
/* AlunoDAO.alunos.Add(new Aluno()
{
    Id = 1,
    Email = "aluno@senac.com",
    Senha = "aluno"
}); */
Console.Clear();
AlunoController alunoController = new AlunoController();
alunoController.AdicionarAluno();

LoginView.Exibir();
