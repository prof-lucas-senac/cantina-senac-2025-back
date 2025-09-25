static class FeedbackController
{   //Algumas coisa vao mudar para DAO
    private static FeedbackDAO feedbackDAO = new FeedbackDAO();
    public static void AdicionarFeedback(Feedback feedback)
    {
        feedback.UsuarioId = 1;
        feedback.DataPublicacao = DateTime.Now;
        feedbackDAO.Cadastrar(feedback);
    }
    // remover apenas se id do aluno for igual id do aluno no feedback
    public static void RemoverFeedback(int id)
    {
    }
    public static void EditarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1; //Depois
        feedbackDAO.Atualizar(feedback);
    }
    public static List<Feedback> ListarFeedback()
    {
        List<Feedback> feedbacks = new FeedbackDAO().ListarTodos();
        return feedbacks;
    }
}