static class FeedbackController
{   //Algumas coisa vao mudar para DAO
    static FeedbackDAO feedbackDAO = new FeedbackDAO();
    public static void AdicionarFeedback(string descricao, int avaliacao, Usuario usuario)
    {
        Feedback feedback = new Feedback();
        feedback.Descricao = descricao;
        feedback.Avaliacao = avaliacao;
        feedback.Usuario = usuario;
        feedback.UsuarioId = usuario.Id;
        feedback.DataPublicacao = DateTime.Now;
        feedbackDAO.Cadastrar(feedback);
    }
    // remover apenas se id do aluno for igual id do aluno no feedback
    public static void RemoverFeedback(int id)
    {
        foreach (Feedback feedback in ListarFeedback())
        {
            if (feedback.Id == id)
            {
                feedbackDAO.Excluir(id);
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
                feedback.DataPublicacao = DateTime.Now;
                feedbackDAO.Atualizar(feedback);
            }
        }
    }
    public static List<Feedback> ListarFeedback()
    {
        List<Feedback> feedbacks = new FeedbackDAO().ListarTodos();
        return feedbacks;
    }
}