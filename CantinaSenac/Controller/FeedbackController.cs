public class FeedbackController
{

    public List<Feedback> Listar()
    {
        FeedbackDAO feedback = new FeedbackDAO();
        return feedback.ListarTodos();
       
    }

    public void PostarFeedback(Feedback feedback)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        feedbackDAO.Cadastrar(feedback);
    }
    public void AtualizarFeedback(Feedback feedback, string novaDescricao)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();

        if (feedback != null)
        {
            feedback.Descricao = novaDescricao;
            feedback.dataPostagem = DateTime.Now;
            feedbackDAO.Atualizar(feedback);
        }
    }
    public void DeletarFeedback(Feedback feedback)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        feedbackDAO.Excluir(feedback);
    }
    public Feedback listarPorId(int id)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        if (feedbackDAO != null){  
            return feedbackDAO.ListarPorId(id);
        }else{
            return null;
        }
        

     }

}