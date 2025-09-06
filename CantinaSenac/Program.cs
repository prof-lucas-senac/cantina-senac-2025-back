
        // Adiciona aluno fictício
        Aluno aluno = new Aluno()
        {
            Id = 1,
            NomeDoUsuario = "Alan",
            Email = "alan",
            Senha = "123"
        };

        new AlunoController().Adicionar(aluno);
LoginView.Exibir();



       

        
