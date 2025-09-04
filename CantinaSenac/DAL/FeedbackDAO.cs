public class FeedbackDAO
{
    public static List<Feedback> feedbacks = new List<Feedback>();

    public static void Adicionar(Feedback feedback)
    {
        feedbacks.Add(feedback);
    }

    public static List<Feedback> Listar()
    {
        return feedbacks;
    }
}