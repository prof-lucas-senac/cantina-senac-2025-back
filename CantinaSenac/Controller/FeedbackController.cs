static class FeedbackController
{   //Algumas coisa vao mudar para DAO
    static int id = 1;
    public static void AdicionarFeedback(string descricao, int avaliacao)
    {
        Feedback feedback = new Feedback();
        feedback.Descricao = descricao;
        feedback.Avaliacao = avaliacao;
        feedback.Id = id;
        id++;
        feedback.DataPublicacao = DateTime.Now;
        ListarFeedback().Add(feedback);
    }
    // remover apenas se id do aluno for igual id do aluno no feedback
    public static void RemoverFeedback(int id)
    {
        foreach (Feedback feedback in ListarFeedback())
        {
            if (feedback.Id == id)
            {
                ListarFeedback().Remove(feedback);
            }
        }

    }
    public static void EditarFeedback(string descricao, int avaliacao, int id)
    {
        foreach (Feedback feedback in ListarFeedback())
        {
            if (feedback.Id == id)
            {
                feedback.Descricao = descricao;
                feedback.Avaliacao = avaliacao;    
            }
        }
    }
    public static List<Feedback> ListarFeedback()
    {
        List<Feedback> feedbacks = new FeedbackDAO().ListarTodos();
        return feedbacks;
    }
}