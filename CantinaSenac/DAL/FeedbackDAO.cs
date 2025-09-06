
class FeedbackDAO : IDAO<Feedback>
{
    public static List<Feedback> feedbacks = new List<Feedback>();
    public void Atualizar(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        feedbacks.Add(feedback);
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Feedback Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Feedback> ListarTodos()
    {
        return feedbacks;
    }
}