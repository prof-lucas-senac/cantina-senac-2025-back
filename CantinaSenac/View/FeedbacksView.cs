static class FeedbacksView
{
    public static void Exibir()
    {
        FeedbackController controller = new FeedbackController();
        bool loping = true;

        while (loping)
        {
            List<Feedback> feedbacks = controller.Listar();
            Console.Clear();
            Console.WriteLine("\nLISTA DE FEEDBACKS");

            if (feedbacks.Count == 0)
            {
                Console.WriteLine("Nenhum feedback cadastrado ainda.");
            }
            else
            {
                controller.Listar();
            }
            Console.WriteLine("\nBem vindo ao Menu de Feedbacks!");
            Console.WriteLine("\n Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar novo feedback");
            Console.WriteLine("2 - Alterar Feedback");
            Console.WriteLine("3 - Excluir Feedback");
            Console.WriteLine("4 - listar Feedback");
            Console.WriteLine("5 - Sair");

            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Criar();
                    break;
                case "2":
                    Alterar();
                    break;
                case "3":
                    Excluir();
                    break;
                case "4":
                    listarFeedback();
                    break;

                case "5":
                    System.Console.WriteLine("\nObrigado por acessar o menu de feedbacks! Até mais!");
                    Console.ReadKey();
                    loping = false;
                    break;

                default: break;
            }
        }
    }

    private static void Criar()
    {
        // Feedback feedback = new Feedback();
        Console.WriteLine("Por favor, deixe seu feedback sobre a cantina:");
        string descricaoFeedback = Console.ReadLine();

        // new FeedbackController().PostarFeedback(descricaoFeedback);

        Console.WriteLine("Feedback cadastrado com sucesso! Pressione Enter para continuar");
        Console.ReadKey();
    }

    private static void Alterar()
    {
        FeedbackController controller = new FeedbackController();

        Console.WriteLine("Digite o ID do feedback que deseja alterar:");
        int id = int.Parse(Console.ReadLine());

        List<Feedback> feedbacks = controller.Listar();
        bool encontrado = true;

        foreach (var feedback in feedbacks)
        {
            if (feedback.Id == id)
            {
                Console.WriteLine($"Feedback atual: {feedback.Descricao}");
                Console.WriteLine("Digite a nova descrição do feedback:");
                string novaDescricao = Console.ReadLine();

                feedback.Descricao = novaDescricao;
                controller.AtualizarFeedback(feedback, novaDescricao);

                Console.WriteLine("Feedback atualizado com sucesso! Pressione Enter para continuar.");
                Console.ReadKey();
                encontrado = false;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Feedback não encontrado! Pressione Enter para continuar.");
            Console.ReadKey();
        }
    }
    private static void Excluir()
    {
        FeedbackController controller = new FeedbackController();

        Console.WriteLine("Digite o ID do feedback que deseja excluir:");
        int id = int.Parse(Console.ReadLine());

        List<Feedback> feedbacks = controller.Listar();
        bool encontrado = false;

        foreach (var feedback in feedbacks)
        {
            if (feedback.Id == id)
            {
                controller.DeletarFeedback(feedback);

                Console.WriteLine("Feedback excluído com sucesso! Pressione Enter para continuar.");
                Console.ReadKey();
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Feedback não encontrado! Pressione Enter para continuar.");
            Console.ReadKey();
        }
    }

    public static void listarFeedback()
    {
        System.Console.WriteLine("Informe o Id do feedback que deseja listar:");
        int id = int.Parse(Console.ReadLine());
        Feedback? feedbackSelecionado = new FeedbackController().listarPorId(id);
        if (feedbackSelecionado != null)
        {
            System.Console.WriteLine($"ID: {feedbackSelecionado.Id} - Descrição: {feedbackSelecionado.Descricao} - Data de Postagem: {feedbackSelecionado.dataPostagem}");
        }
        else
        {
            System.Console.WriteLine("Feedback não encontrado.");
        }
        System.Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }
}
