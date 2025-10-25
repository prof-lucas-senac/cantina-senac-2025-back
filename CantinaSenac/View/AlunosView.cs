static class AlunosView
{
    public static void Exibir()
    {
        System.Console.WriteLine("Bem-vind@ ao Gerenciamento de Alunos!\n");
        System.Console.WriteLine("Selecione uma opção:");
        System.Console.WriteLine("1. Listar Alunos");
        System.Console.WriteLine("2. Adicionar Aluno");
        System.Console.WriteLine("3. Atualizar Aluno");
        System.Console.WriteLine("4. Remover Aluno");
        System.Console.WriteLine("5. Voltar");
        string opcao = Console.ReadLine()!;
        switch (opcao)
        {
            case "1":
                ListarAlunos();
                break;
            case "2":
                AdicionarAluno();
                break;
            case "3":
                AtualizarAluno();
                break;
            case "4":
                RemoverAluno();
                break;
            case "5":
                AdminView.Exibir();
                break;
            default:
                System.Console.WriteLine("Opção inválida. Tente novamente.");
                Exibir();
                break;
        }
    }

    private static void ListarAlunos()
    {
        AlunoController alunoController = new AlunoController();
        List<Aluno> alunos = alunoController.ListarAlunos();

        System.Console.WriteLine("Lista de Alunos:\n");
        foreach (var aluno in alunos)
        {
            System.Console.WriteLine($"ID: {aluno.Id}, Nome: {aluno.NomeDoUsuario}, Email: {aluno.Email}");
        }

        System.Console.WriteLine("\nPressione qualquer tecla para retornar ao menu de Alunos.");
        Console.ReadKey();
        Exibir();
    }

    private static void AdicionarAluno()
    {
        Aluno novoAluno = new Aluno();

        System.Console.WriteLine("Informe o nome do aluno:");
        novoAluno.NomeDoUsuario = Console.ReadLine()!;

        System.Console.WriteLine("Informe o email do aluno:");
        novoAluno.Email = Console.ReadLine()!;

        AlunoController alunoController = new AlunoController();
        alunoController.AdicionarAluno(novoAluno);

        System.Console.WriteLine("Aluno adicionado com sucesso! Pressione qualquer tecla para retornar ao menu de Alunos.");
        Console.ReadKey();
        Exibir();
    }

    private static void AtualizarAluno()
    {
        Aluno alunoAtualizado = new Aluno();

        System.Console.WriteLine("Informe o ID do aluno a ser atualizado:");
        alunoAtualizado.Id = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Informe o novo nome do aluno:");
        alunoAtualizado.NomeDoUsuario = Console.ReadLine()!;

        System.Console.WriteLine("Informe o novo email do aluno:");
        alunoAtualizado.Email = Console.ReadLine()!;

        AlunoController alunoController = new AlunoController();
        alunoController.AtualizarAluno(alunoAtualizado);

        System.Console.WriteLine("Aluno atualizado com sucesso! Pressione qualquer tecla para retornar ao menu de Alunos.");
        Console.ReadKey();
        Exibir();
    }

    private static void RemoverAluno()
    {
        Aluno alunoParaRemover = new Aluno();

        System.Console.WriteLine("Informe o ID do aluno a ser removido:");
        alunoParaRemover.Id = Convert.ToInt32(Console.ReadLine());

        AlunoController alunoController = new AlunoController();
        alunoController.ExcluirAluno(alunoParaRemover);

        System.Console.WriteLine("Aluno removido com sucesso! Pressione qualquer tecla para retornar ao menu de Alunos.");
        Console.ReadKey();
        Exibir();
    }
}