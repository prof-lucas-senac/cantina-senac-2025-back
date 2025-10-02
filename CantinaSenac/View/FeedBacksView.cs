// Classe estática responsável por exibir, cadastrar, alterar e excluir feedbacks no console
static class FeedBacksView
{
    // Exibe o menu principal de gerenciamento de feedbacks
    public static void Exibir( )
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
            Console.WriteLine("5 - Exibir detalhes do Feedback");
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
                    CadastrarFeedback();
                    break;

                case "3":
                    AlterarFeedback();
                    break;

                case "4":
                    ExcluirFeedback();
                    break;

                case "5":
                    ExibirDetalhesFeedbacks();
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

    private static void ExibirDetalhesFeedbacks()
    {
        System.Console.WriteLine("Informe o ID do feedback a ser exibido: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Feedback feedbackSelecionado = new FeedbackController().ListarPorId(id);

        if (feedbackSelecionado != null)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"ID do Feedback: {feedbackSelecionado.Id}");
            Console.WriteLine($"ID do Autor: {feedbackSelecionado.UsuarioId}");
            Console.WriteLine($"Comentário: {feedbackSelecionado.Descricao}");
            Console.WriteLine($"Data: {feedbackSelecionado.DataPublicacao}");
        }
        else
        {
            System.Console.WriteLine($"Feedbacks não encontrado.\n");
        }

        System.Console.WriteLine("Pressione qualquer tecla para retornar a tela de feedbakcs.");
        Console.ReadKey();
        Exibir();
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
    public static void CadastrarFeedback( )
    {
        Console.Clear();
        Console.WriteLine("=== Cadastrar Feedback ===\n");

        Console.Write("Comentário: ");
        string descricao = Console.ReadLine();

        var feedback = new Feedback
        {
            Descricao = descricao,
            DataPublicacao = DateTime.Now,
        };

        new FeedbackController().Cadastrar(feedback);

        Console.WriteLine("\nFeedback enviado com sucesso!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }

    // Permite alterar um feedback existente
    private static void AlterarFeedback( )
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
