// See https://aka.ms/new-console-template for more information
new AlunoControler().Adicionar(new Aluno()
{
    Id = 1,
    Email = "aluno@senac.br",
    Senha = "aluno",
});
Aluno aluno = new Aluno();
aluno.Id = 2;
FeedbackController.AdicionarFeedback("TESTESTETSTESTE",6,aluno);
LoginView.Exibir();