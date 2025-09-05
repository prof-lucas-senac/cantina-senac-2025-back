public class FeedbackView
{
    public void ExibirFeedbacks()
    {
        FeedbackController controller = new FeedbackController();
       
        var feedbacks = controller.ListarFeedbacks();

        Console.WriteLine("\n--- Lista de Feedbacks ---");
        foreach (var f in feedbacks)
        {
            Console.WriteLine($"Comentário: {f.Comentario}");
        }

        Console.Write("\nDeseja adicionar um novo feedback? (s/n): ");
        string resposta = Console.ReadLine();

        if (resposta.ToLower() == "s")
        {
            Console.Write("Digite o comentário: ");
            string comentario = Console.ReadLine();

            controller.AdicionarFeedback(comentario);
            Console.WriteLine("Feedback adicionado com sucesso!");
        }
    }
}
