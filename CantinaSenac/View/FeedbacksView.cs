using System.Runtime.CompilerServices;

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
    }

    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }
    private static void Cadastrar()
    {
        
        Feedback feedback = new Feedback();
        Console.WriteLine("Poste seu Feedback aqui: ");
        feedback.Descricao = Console.ReadLine();
        System.Console.WriteLine("Feedback postado");
        Console.ReadKey();
        Exibir();        
    }


}