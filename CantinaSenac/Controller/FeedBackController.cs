public class FeedBackController
{
    public void AdicionarFeedBack()
    {
        FeedBackDAO feedBackDAO = new FeedBackDAO();
        FeedBack feedBack = new FeedBack();

        Console.Write("Digite seu comentário: "); feedBack.Descricao = Console.ReadLine();

        feedBackDAO.Adicionar(feedBack);
    }
    public bool VerificarSeTemFeedBacks()
    {
        List<FeedBack> feedBacks = new FeedBackDAO().ListarFeedBacks();
        foreach (FeedBack feedBack in feedBacks)
        {
            Console.WriteLine(feedBack.Descricao);
        }
        if (feedBacks.Count != 0)
        {
            return true;
        }
        return false;
    }
}