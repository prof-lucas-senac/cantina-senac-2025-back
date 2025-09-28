using System.Diagnostics;

static class FeedbacksView
{

    public static void Exibir()
    {
        List<Feedback> feedbacks;

        Console.Clear();
        System.Console.WriteLine("Cantina SENAC");
        System.Console.WriteLine("Lista de Feedbacks:");
        feedbacks = new FeedbackController().ListarFeedbacks();
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            System.Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }


        CantinaSenacContext contexto = new CantinaSenacContext();
        Console.WriteLine($"Bem vindo ao menu Feedback! O que você deseja fazer?");
        Console.WriteLine($"1- Adicionar Feedback;");
        Console.WriteLine($"2- Editar Feedback;");
        Console.WriteLine($"3- Excluir Feedback;");
        Console.WriteLine($"4- Listar todos;");
        Console.WriteLine($"5- Sair.");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                ExibirDialogoPostarFeedback();
                break;

            case 2:
                ExibirDialogoEditarFeedback();
                break;

            case 3:
                ExibirDialogodeExcluirFeedback();
                break;

            case 4:
                ListarFeedbacks(new FeedbackController().ListarFeedbacks());
                Console.ReadKey();
                Exibir();
                break;

            case 5:
                Console.WriteLine("Obrigado por usar o Menu Feedback!");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                Exibir();
                break;
        }
    }
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }

    public static void ExibirDialogoPostarFeedback()
    {
        System.Console.WriteLine("Poste o seu feedback:");
        string descricaoFeedback = Console.ReadLine();

        new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }


    public static void ExibirDialogoEditarFeedback()
    {
        Feedback feedbackEditar = new Feedback();
        //FeedbackDAO feedBacDao = new FeedbackDAO();
        Console.WriteLine($"Insira o id do comentario que deseja editar.");
        int idEditar = Convert.ToInt32(Console.ReadLine());
        feedbackEditar.Id = idEditar;

        Console.WriteLine($"Insira um novo Feedback.");
        feedbackEditar.Descricao = Console.ReadLine();

        new FeedbackController().AtualizarFeedback(feedbackEditar);

        Console.WriteLine($"Feedback atualizado.");

        System.Console.WriteLine("Feedback postado com sucesso! Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();



    }

    public static void ExibirDialogodeExcluirFeedback()
    {
        Feedback feedbackExcluir = new Feedback();
        Console.WriteLine($"Informe o ID do Feedback que deseja excluir.");
        int idExcluir = Convert.ToInt32(Console.ReadLine());
        feedbackExcluir.Id = idExcluir;
        new FeedbackController().ExcluirFeedback(feedbackExcluir);
    }
}