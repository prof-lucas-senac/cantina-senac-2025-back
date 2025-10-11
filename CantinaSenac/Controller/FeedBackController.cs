public class FeedBackController
{
    private FeedBackDAO feedBackDAO = new FeedBackDAO();
    public void AdicionarFeedBack(FeedBack feedBack)
    {
        feedBack.UsuarioId = 1;
        feedBack.DataPublicacao = DateTime.Now;
        feedBackDAO.Cadastrar(feedBack);
    }
    public List<FeedBack> ListarTodosFeedBacks()
    {
        List<FeedBack> feedBacks = new FeedBackDAO().ListarTodos();
        return feedBacks;
        /*foreach (FeedBack feedBack in feedBacks)
        {
            Console.WriteLine($"Decrição: {feedBack.Descricao}");
            Console.WriteLine("ID: " + feedBack.Id);
            Console.WriteLine("----------");
        } */
    }
    public void AlterarFeedBack(FeedBack feedBack)
    {
        feedBack.DataPublicacao = DateTime.Now;
        feedBack.UsuarioId = 1;
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