// See https://aka.ms/new-console-template for more information

new AlunoController().Cadastrar(new Aluno()
{
    Id = 1,
    Email = "aluno@senac.br",
    Senha = "aluno",
});

LoginView.Exibir();
