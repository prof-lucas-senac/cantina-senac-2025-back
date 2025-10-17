public class FeedBackController
{
    private FeedBackDAO feedBackDAO = new FeedBackDAO();
    public void AdicionarFeedBack(FeedBack feedBack)
    {
        feedBackDAO.Cadastrar(feedBack);
    }
    public List<FeedBack> ListarTodosFeedBacks()
    {
        List<FeedBack> feedBacks = new FeedBackDAO().ListarTodos();
        return feedBacks;
    }
    public void AlterarFeedBack(FeedBack feedBack)
    {
        feedBackDAO.Atualizar(feedBack);
    }
    public void ExcluirFeedBack(FeedBack feedBack)
    {
        feedBackDAO.Excluir(feedBack);
    }
    public FeedBack ListarPorId(int id)
    {
        FeedBack feedBack = feedBackDAO.ListarPorId(id);

        if (feedBack != null)
        {
            return feedBack;
        }
        else
        {
            return null;
        }
    }
}