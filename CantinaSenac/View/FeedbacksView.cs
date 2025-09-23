static class FeedbacksView
{
    public static void Exibir()
    {
<<<<<<< HEAD
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
        ExibirDialogoPostarFeedback();
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
        string? descricaoFeedback = Console.ReadLine();

        new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

    
=======
        System.Console.WriteLine("====================//====================");
        System.Console.WriteLine("Bem-vindo à seção de feedbacks!");
        System.Console.WriteLine("====================//====================");
    }
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
}