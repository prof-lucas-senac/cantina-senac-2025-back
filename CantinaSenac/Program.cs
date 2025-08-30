
// Adiciona alunos fictícios à lista
new AlunoController().Adicionar(new Aluno()
{
    Id = 1,
    Email = "aluno@senac.br",
    Senha = "aluno",
});



// Exibe a tela de login
LoginView.Exibir();


