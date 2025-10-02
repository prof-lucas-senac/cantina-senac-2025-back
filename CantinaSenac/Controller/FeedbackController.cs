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
        dao.Cadastrar(feedback);
    }


    public void AtualizarFeedback(Feedback feedBack)
    {
        feedBack.DataPublicacao = DateTime.Now;
        feedBack.UsuarioId = 1;
        dao.Atualizar(feedBack);
    }

    public void ExcluirFeedback(Feedback feedback)
    {
        feedback.UsuarioId = 1;
        dao.Excluir(feedback);
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
            return null;
        }
    }
}