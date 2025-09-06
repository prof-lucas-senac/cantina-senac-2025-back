// See https://aka.ms/new-console-template for more information

Console.Clear();
/*AlunoController alunoController = new AlunoController();
Aluno aluno = new Aluno();
alunoController.AdicionarAluno(aluno); */

new AlunoController().AdicionarAluno(new Aluno()
{
    Id = 1,
    Email = "abc",
    Senha = "123",
});
LoginView.Exibir();
