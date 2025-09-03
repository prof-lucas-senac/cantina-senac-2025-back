<<<<<<< HEAD
﻿AlunoController alunoControle = new AlunoController();
alunoControle.AdicionarAluno();

LoginView.Exibir();
=======
﻿// See https://aka.ms/new-console-template for more information
new AlunoController().Adicionar(new Aluno()
{
    Id = 1,
    Email = "aluno@senac.br",
    Senha = "aluno",
});
LoginView.Exibir();
>>>>>>> master
