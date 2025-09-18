public class FeedbacksController
{
    public static void AdicionarFeedback(Feedback feedback)
    {
        feedback.UsuarioId = 1;
        new FeedbackDAO().Cadastrar(feedback);
    }

    public static void MostrarFeedbacks()
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
                Console.WriteLine(feedback.decricao);
                Console.WriteLine("======================================");
            }
        }
    }

}