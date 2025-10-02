static class FeedbackController
{
    private static FeedbackDAO feedbackDAO = new FeedbackDAO();
    public static void AdicionarFeedback(Feedback feedback)
    {
        feedback.UsuarioId = 1;
        feedback.DataPublicacao = DateTime.Now;
        feedbackDAO.Cadastrar(feedback);
    }
    public static void RemoverFeedback(Feedback feedback)
    {
        feedbackDAO.Excluir(feedback);
    }
    public static void EditarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
        feedbackDAO.Atualizar(feedback);
    }
    public static List<Feedback> ListarFeedback()
    {
        List<Feedback> feedbacks = new FeedbackDAO().ListarTodos();
        return feedbacks;
    }
    public static Feedback ListarPorId(int id)
    {
        Feedback feedback = feedbackDAO.ListarPorId(id);
        if (feedback != null)
        {
            return feedback;
        }
        else
        {
            return null;
        }
    }
}