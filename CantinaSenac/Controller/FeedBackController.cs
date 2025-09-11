class FeedBackController
{
    public void AdicionarFeedBack(FeedBack feedBack)
    {
        FeedBackDAO feedBackDAO = new FeedBackDAO();
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
}