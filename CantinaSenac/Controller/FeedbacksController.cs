public class FeedbacksController
{
    private FeedbackDAO feedbackDAO = new FeedbackDAO();
    public void AdicionarFeedback(Feedback feedback)
    {
        feedbackDAO.Cadastrar(feedback);
    }
    
    public void RemoverFeedback(Feedback feedback)
    {
        feedbackDAO.Excluir(feedback);

    }
    public void AtualizarFeedback(Feedback feedback)
    {
        feedbackDAO.Atualizar(feedback);
    }

    public List<Feedback> MostrarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
        
    }
    public Feedback ListarPorId(int id)
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