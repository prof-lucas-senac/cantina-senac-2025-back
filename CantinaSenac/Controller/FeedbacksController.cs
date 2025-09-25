class FeedbackController
{
    private FeedbackDAO dao = new FeedbackDAO();
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    public void PostarFeedback(string descricaoFeedback)
    {
        
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        dao.Cadastrar(feedback);
    }
    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicação = DateTime.Now;
        feedback.UsuarioId = 1;
        dao.Atualizar(feedback);
    }
}