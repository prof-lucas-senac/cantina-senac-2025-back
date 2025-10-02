public class FeedbacksController
{
    private FeedbackDAO feedbackDAO = new FeedbackDAO();
    public void AdicionarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;

        feedbackDAO.Cadastrar(feedback);
    }
    public void RemoverFeedback(Feedback feedback)
    {
        feedbackDAO.Excluir(feedback);

    }

    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;

        feedbackDAO.Atualizar(feedback);
    }

    public void MostrarFeedbacks()
    {
        List<Feedback> feedbacks = new FeedbackDAO().ListarTodos();
        if (feedbacks.Count == 0)
        {
            Console.WriteLine("Sem feedbacks");
            Console.WriteLine("======================================");
        }
        else
        {
            foreach (Feedback feedback in feedbacks)
            {
                Console.WriteLine(feedback.Id + " || " + feedback.decricao);
                Console.WriteLine("======================================");
            }
        }
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