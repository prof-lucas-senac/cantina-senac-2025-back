public class FeedbackDAO
{
    private static List<Feedback> Feedbacks = new List<Feedback>();

    public void Adicionar(Feedback feedback)
    {
        Feedbacks.Add(feedback);
    }
    public List<Feedback> ListarTodos()
    {
        return Feedbacks;
    }
}