class FeedBackController
{
    private FeedBackDAO feedBackDAO = new FeedBackDAO();
    public void AdicionarFeedBack(FeedBack feedBack)
    {
        feedBack.UsuarioId = 1;
        feedBack.DataPublicacao = DateTime.Now;
        feedBackDAO.Cadastrar(feedBack);
    }
    public void ListarTodosFeedBacks()
    {
        List<FeedBack> feedBacks = new FeedBackDAO().ListarTodos();
        foreach (FeedBack feedBack in feedBacks)
        {
            Console.WriteLine("Descrição: " + feedBack.Descricao);
            Console.WriteLine("ID: " + feedBack.Id);
            Console.WriteLine("----------");
        }
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
}