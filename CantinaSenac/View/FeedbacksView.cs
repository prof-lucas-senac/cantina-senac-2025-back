public class FeedbackView 
{
    public void ExibirFeedbacks()
    {
        FeedbackController controller = new FeedbackController();

        Console.Write("Digite a senha para visualizar os feedbacks: ");
        string senha = Console.ReadLine();

        var feedbacks = controller.ListarFeedbacks(senha);

        if (feedbacks.Count > 0)
        {
            Console.WriteLine("\n--- Lista de Feedbacks ---");
            foreach (var f in feedbacks)
            {
                Console.WriteLine($"ID: {f.Id}, Comentário: {f.Comentario}, Data: {f.Data}, AlunoId: {f.AlunoId}");
            }
        }
    }
}
