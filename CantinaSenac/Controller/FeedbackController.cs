public class FeedbackController
{
    private FeedbackDAO dao = new FeedbackDAO();
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    public void PostarFeedback(Feedback feedback)
    {
        dao.Cadastrar(feedback);
    }


    public void AtualizarFeedback(Feedback feedBack)
    {
        dao.Atualizar(feedBack);
    }

    public Feedback? ListarPorId(int id)
    {
        Feedback feedback = dao.ListarPorId(id);

        if (feedback != null)
        {
            return feedback;
        }
        else
        {
            return null;
        }
    }
    
    public void ExcluirFeedback(Feedback feedback)
    {
        feedback.UsuarioId = 1;
        dao.Excluir(feedback);
    }
}