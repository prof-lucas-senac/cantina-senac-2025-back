static class FeedbacksView
{
    public static void Exibir()
    {
        List<Feedback> feedbacks;

        Console.Clear();
        System.Console.WriteLine("Cantina SENAC");
        System.Console.WriteLine("menu de opções:\n");

        feedbacks = new FeedbackController().ListarFeedbacks();
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            System.Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }
<<<<<<< HEAD
        ExibirDialogoPostarFeedback();
        System.Console.WriteLine("1 adicionar feedback");
        System.Console.WriteLine("2 alterar feedback");
        System.Console.WriteLine("3 remover feedback");
=======
        System.Console.WriteLine("Menu de opções:\n");
        System.Console.WriteLine("1. Adicionar Feedback;");
        System.Console.WriteLine("2. Alterar Feedback;");
        System.Console.WriteLine("3. Excluir Feedback;");
>>>>>>> 2463e34d1beaaa2a58ebbd433ddf1af8d5e4afee
        switch (Console.ReadLine())
        {
            case "1":
                ExibirDialogoPostarFeedback();
                break;
            case "2":
                ExibirDialogoAtualizarFeedback();
                break;
            case "3":
                break;
<<<<<<< HEAD
            default:
                System.Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                Exibir();
                break;
        }
    }


=======
        }
    }

    private static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        System.Console.WriteLine("Informe o Id do Feedback a ser atualizado:");
        feedback.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Insira o novo feedback:");
        feedback.Descricao = Console.ReadLine();

        new FeedbackController().AtualizarFeedback(feedback);
        
        System.Console.WriteLine("Feedback atualizado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
>>>>>>> 2463e34d1beaaa2a58ebbd433ddf1af8d5e4afee
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }

    private static void ExibirDialogoPostarFeedback()
    {
        System.Console.WriteLine("Poste o seu feedback:");
        string descricaoFeedback = Console.ReadLine()!;

        new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
    private static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        System.Console.WriteLine("informe o id do feedback que deseja alterar:");
        feedback.Id = Convert.ToInt32(Console.ReadLine()!);

        System.Console.WriteLine("informe a nova descrição do feedback:");
        feedback.Descricao = Console.ReadLine()!;
        
        new FeedbackController().AtualizarFeedback(feedback);

        System.Console.WriteLine("Feedback alterado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
}