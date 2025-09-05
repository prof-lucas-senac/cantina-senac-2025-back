public class FeedbacksController
{
    public static void AdicionarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("adicione um feedback");
        feedback.decricao = Console.ReadLine();

        new FeedbackDAO().Adicionar(feedback);
    }

    public static void MostrarFeedbacks()
    {
        List<Feedback> feedbacks = new FeedbackDAO().ListarTodos();
        if (feedbacks.Count == 0)
        {
            Console.WriteLine("Sem feedbacks");
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