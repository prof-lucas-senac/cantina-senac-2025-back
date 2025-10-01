class FeedbackController
{
    private FeedbackDAO dao = new FeedbackDAO();
    public List<Feedback> ListarFeedbacks()
    {
        return dao.ListarTodos();
    }

    public void PostarFeedback(string descricaoFeedback)
    {
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        feedback.DataPublicacao = DateTime.Now;
        dao.Cadastrar(feedback);
    }
<<<<<<< HEAD
=======

>>>>>>> 2463e34d1beaaa2a58ebbd433ddf1af8d5e4afee
    public void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
        dao.Atualizar(feedback);
    }
<<<<<<< HEAD
    public void ExcluirFeedback(Feedback feedback)
    {
        dao.Excluir(feedback);
    }
=======
>>>>>>> 2463e34d1beaaa2a58ebbd433ddf1af8d5e4afee
}