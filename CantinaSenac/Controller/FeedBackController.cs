class FeedBackController
{
    private FeedBackDAO feedBackDAO = new FeedBackDAO();
    public void AdicionarFeedBack(FeedBack feedBack)
    {
        feedBack.UsuarioId = 1;
        feedBack.DataPublicacao = DateTime.Now;
        feedBackDAO.Cadastrar(feedBack);
    }
    public bool VerificarSeTemFeedBacks()
    {
        List<FeedBack> feedBacks = new FeedBackDAO().ListarTodos();
        if (feedBacks.Count != 0)
        {
            return true;
        }
        return false;
    }
    public void ListarTodosFeedBacks()
    {
        List<FeedBack> feedBacks = new FeedBackDAO().ListarTodos();
        foreach (FeedBack feedBack in feedBacks)
        {
            Console.WriteLine(feedBack.Descricao);
        }
    }
    public void AlterarFeedBack(FeedBack feedBack)
    {
        feedBack.DataPublicacao = DateTime.Now;
        feedBack.UsuarioId = 1;
        feedBackDAO.Atualizar(feedBack);
    }
}