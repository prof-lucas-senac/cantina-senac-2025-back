public class FeedbackController
{
    private FeedbackDAO feedbackDAO = new FeedbackDAO();
    private const string senhaCorreta = "1234"; 

    public List<Feedback> ListarFeedbacks(string senha)
    {
        if (senha == senhaCorreta)
        {
            return feedbackDAO.ListarTodos();
        }
        else
        {
            Console.WriteLine("Senha incorreta. Acesso negado.");
            return new List<Feedback>();
        }
    }
}
