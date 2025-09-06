static class FeedbacksView
{
    public static void Exibir()
    {
        List<Feedback> feedbacks;
        Console.Clear();

        System.Console.WriteLine("Cantina SENAC");
        


        System.Console.Write($"Digite seu comentario:");
        string novoComentario = Console.ReadLine();
        new FeedbackController().ValidarCometario(novoComentario);


        feedbacks = new List<Feedback>();
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
}