public class FeedbackController
{
    public FeedbackDAO feedbackDAO = new FeedbackDAO();

    public List<Feedback> ListarFeedbacks()
    {
        return feedbackDAO.ListarTodos();
    }

    public void AdicionarFeedback(string comentario)
    {
        var novoFeedback = new Feedback
        {
            Id = FeedbackDAO.feedbacks.Count + 1,
            Comentario = comentario,};

        feedbackDAO.Cadastrar(novoFeedback);
    }
}
