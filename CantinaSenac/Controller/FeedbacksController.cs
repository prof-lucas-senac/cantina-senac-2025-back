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
        feedback.DataPublicacao = DateTime.Now;
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        dao.Cadastrar(feedback);
    }

    public void ExcluirFeedback(Feedback feedback)
    {
      
       
        feedback.UsuarioId = 1;
        dao.Excluir(feedback);
    }

    public void EditarFeedback(Feedback feedback)
    {
       
         feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
        dao.Atualizar(feedback);
        
    }
    
    
}