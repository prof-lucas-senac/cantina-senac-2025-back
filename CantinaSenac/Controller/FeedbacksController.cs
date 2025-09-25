public class FeedbacksController
{
    private FeedbackDAO feedbackDAO = new FeedbackDAO();
    public void AdicionarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;

        feedbackDAO.Cadastrar(feedback);
    }
    public void RemoverFeedback(int id)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        List<Feedback> feedbacks = feedbackDAO.ListarTodos();
        foreach (Feedback item in feedbacks)
        {
            if (item.Id == id)
            {
                feedbackDAO.Excluir(item);
            }
        }
    }
    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
        
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

}