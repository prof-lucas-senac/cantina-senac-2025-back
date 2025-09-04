
class FeedbackDAO
{

    public static List<Feedback> feedbacks = new List<Feedback>();
    public void Atualizar(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        feedback.Id = feedbacks.Count + 1;
        feedbacks.Add(feedback);
    }

    public void Excluir(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public Feedback Listar(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public List<Feedback> ListarTodos()
    {

        return feedbacks;


    }
}