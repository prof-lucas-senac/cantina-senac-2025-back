public class FeedBackDAO
{
    private static List<FeedBack> feedBacks = new List<FeedBack>();

    public void Adicionar(FeedBack feedBack)
    {
        feedBacks.Add(feedBack);
    }
    public List<FeedBack> ListarFeedBacks()
    {
        return feedBacks;
    }
}