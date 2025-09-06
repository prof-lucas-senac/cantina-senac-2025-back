using System.Runtime.CompilerServices;

class FeedbackController : FeedbackDAO
{
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    public void PostarFeedBack(Feedback feedbackDescricao)
    {
        
    }

    

}