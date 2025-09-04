public class FeedbackDAO
{
    public static List<Feedback> feedbacks = new List<Feedback>
    {
        new Feedback { Id = 1, Comentario = "Ótimo curso!", Data = DateTime.Now, AlunoId = 101 },
        new Feedback { Id = 2, Comentario = "Precisa melhorar o conteúdo.", Data = DateTime.Now, AlunoId = 102 }
    };

    public List<Feedback> ListarTodos()
    {
        return feedbacks;
    }
}
