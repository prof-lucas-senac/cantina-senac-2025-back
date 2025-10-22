public class FeedbackController
{
    private FeedbackDAO dao = new FeedbackDAO();
    public List<Feedback> ListarFeedbacks()
    {
        return dao.ListarTodos();
    }

    public void PostarFeedback(Feedback feedback)
    {        
        dao.Cadastrar(feedback);
    }

    public void ExcluirFeedback(Feedback feedback)
    {
        dao.Excluir(feedback);
    }
    public void AtualizarFeedback(Feedback feedback)
    {
        dao.Atualizar(feedback);
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
}