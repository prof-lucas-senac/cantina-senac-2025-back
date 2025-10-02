class FeedbackController
{
    private FeedbackDAO dao = new FeedbackDAO();
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    public void PostarFeedback(string descricaoFeedback)
    {
        FeedbackDAO dao = new FeedbackDAO();
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        dao.Cadastrar(feedback);
    }

    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
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