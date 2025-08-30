// See https://aka.ms/new-console-template for more information
/* AlunoDAO.alunos.Add(new Aluno()
{
    Id = 1,
    Email = "aluno@senac.com",
    Senha = "aluno"
}); */
AlunoController alunoController = new AlunoController();
alunoController.AdicionarAluno();

LoginView.Exibir(); 
