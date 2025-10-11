public class FeedbackController
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
        feedback.DataPublicacao = DateTime.Now;
        dao.Cadastrar(feedback);
    }

    public void ExcluirFeedback(Feedback feedback)
    {
        dao.Excluir(feedback);
    }
    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
        dao.Atualizar(feedback);
    }
    
    public void ExcluirFeedback(int id)
{
    // Buscar o feedback pelo ID
    var feedback = dao.ListarPorId(id);

    if (feedback != null)
    {
        dao.Excluir(feedback);
    }
    else
    {
        //caso não encontre o feedback, lança uma exceção
        throw new Exception("Feedback não encontrado para exclusão.");
    }
}

}