class FeedbackController
{
    public void Adicionar(Feedback feedback)
    {
        new FeedbackDAO().Cadastrar(feedback);
    }
    public void PostarFeedback(string descricaoFeedback)
        {
        Feedback dao = new FeedbackDAO();
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1; // ID do usuário logado (exemplo)
        dao.Cadastrar(feedback);
        }
  
    {
        new FeedbackDAO().Cadastrar(feedback);
    }
}
