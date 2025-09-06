static class FeedbacksView
{
    public static void Exibir()
    {
        List<Feedback> feedbacks;
        Console.Clear();
        Console.WriteLine("Cantina SENAC");
        Console.WriteLine("Lista de Feedbacks:");
        feedbacks = new FeedbackController().ListarFeedbacks();
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }
        
    }

    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            Console.WriteLine(feedback.Descricao);
        }
    }
}