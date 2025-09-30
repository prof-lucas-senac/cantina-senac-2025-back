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
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        feedback.DataPublicacao = DateTime.Now;
        dao.Cadastrar(feedback);
    }

    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
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
}