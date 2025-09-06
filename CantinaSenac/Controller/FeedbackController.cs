class FeedbackController
{
    public void Adicionar(Feedback feedback)
    {
        new FeedbackDAO().Cadastrar(feedback);
    }
}