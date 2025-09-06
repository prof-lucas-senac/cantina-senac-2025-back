class FeedbackController
{
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    public void Cadastrar(Feedback feedback)
    {
        new FeedbackDAO().Cadastrar(feedback);
    }
}