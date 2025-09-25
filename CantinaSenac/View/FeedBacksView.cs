// Classe estática responsável por exibir, cadastrar, alterar e excluir feedbacks no console
static class FeedBacksView
{
    // Exibe o menu principal de gerenciamento de feedbacks
    public static void Exibir(Aluno aluno)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("===== MENU DE FEEDBACKS =====");
            Console.WriteLine("1 - Listar Feedbacks");
            Console.WriteLine("2 - Adicionar Feedback");
            Console.WriteLine("3 - Alterar Feedback");
            Console.WriteLine("4 - Excluir Feedback");
            Console.WriteLine("0 - Voltar");
            Console.Write("\nEscolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ListarFeedbacks(new FeedbackController().ListarFeedbacks());
                    Console.WriteLine("\nPressione Enter para continuar...");
                    Console.ReadKey();
                    break;

                case "2":
                    CadastrarFeedback(aluno);
                    break;

                case "3":
                    AlterarFeedback(aluno);
                    break;

                case "4":
                    ExcluirFeedback();
                    break;

                case "0":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Exibe os feedbacks formatados no console
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        Console.WriteLine("=== Lista de Feedbacks ===\n");

        if (feedbacks.Count == 0)
        {
            Console.WriteLine("Nenhum Feedback foi postado ainda.");
            return;
        }

        foreach (Feedback feedback in feedbacks)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"ID: {feedback.Id}");
            Console.WriteLine($"Autor: {feedback.Usuario.NomeDoUsuario}");
            Console.WriteLine($"Comentário: {feedback.Descricao}");
            Console.WriteLine($"Data: {feedback.DataPublicacao}");
        }
        Console.WriteLine("-----------------------------------");
    }

    // Coleta dados do usuário e cadastra um novo feedback
    public static void CadastrarFeedback(Usuario usuario)
    {
        Console.Clear();
        Console.WriteLine("=== Cadastrar Feedback ===\n");

        Console.Write("Comentário: ");
        string descricao = Console.ReadLine();

        var feedback = new Feedback
        {
            Descricao = descricao,
            DataPublicacao = DateTime.Now,
            UsuarioId = usuario.Id,
            Usuario = usuario
        };

        new FeedbackController().Cadastrar(feedback);

        Console.WriteLine("\nFeedback enviado com sucesso!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }

    // Permite alterar um feedback existente
    private static void AlterarFeedback(Usuario usuario)
    {
        Console.Clear();
        Console.WriteLine("=== Alterar Feedback ===\n");

        Console.Write("Informe o ID do feedback que deseja alterar: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nova descrição: ");
        string novaDescricao = Console.ReadLine();

        var feedback = new Feedback
        {
            Id = id,
            Descricao = novaDescricao,
            DataPublicacao = DateTime.Now,
            UsuarioId = usuario.Id,
            Usuario = usuario
        };

        var feedbackExistente = new FeedbackController().BuscarPorId(id);
        if (feedbackExistente == null)
        {
            Console.WriteLine("Feedback não encontrado. Pressione Enter para voltar.");
            Console.ReadKey();
            return;
        }


        new FeedbackController().Atualizar(feedback);

        Console.WriteLine("\nFeedback atualizado com sucesso!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }

    // Permite excluir um feedback pelo ID
    private static void ExcluirFeedback()
    {
        Console.Clear();
        Console.WriteLine("=== Excluir Feedback ===\n");

        Console.Write("Informe o ID do feedback que deseja excluir: ");
        int id = int.Parse(Console.ReadLine());

        new FeedbackController().Excluir(id);

        Console.WriteLine("\nFeedback excluído com sucesso!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }
}
