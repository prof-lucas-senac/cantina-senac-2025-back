class FeedbackController
{
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    public void Cadastrar(string descricaoFeedback)
    {
        
        FeedbackDAO dao = new FeedbackDAO();
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        dao.Cadastrar(feedback);
    }
}