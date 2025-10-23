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
 
    public void ExcluirFeedback(Feedback feedback)
    {
        dao.Excluir(feedback);
    }
 
    public void AtualizarFeedback(Feedback feedback)
    {
        dao.Atualizar(feedback);
    }
 
    public void RemoverFeedback(int id)
    {
        Feedback feedback = dao.ListarTodos().FirstOrDefault(f => f.Id == id);
        if (feedback != null)
        {
            dao.Excluir(feedback);
        }
        else
        {
            Console.WriteLine("Feedback não encontrado.");
        }
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