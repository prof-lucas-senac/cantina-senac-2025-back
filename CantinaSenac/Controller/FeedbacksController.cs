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

    public void AtualizarFeedback(Feedback feedback)
    {
        
        dao.Atualizar(feedback);
    }

    public void ExcluirFeedback(int id)
    {
        dao.Excluir(id);
    }
    public Feedback ListarPorId(int id)
    {
        Feedback feedback = dao.ListarPorId(id);

        if (feedback != null)
        {
            return feedback;
        }
        else
        {
            System.Console.WriteLine("Feedback não encontrado!");
            return null;
        }
    }

}