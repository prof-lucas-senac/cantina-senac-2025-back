
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

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Feedback Listar(int id)
    {
        foreach (var item in feedbacks)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        throw new Exception("Feedback não encontrado");
    }

    public List<Feedback> ListarTodos()
    {
        return feedbacks;
    }
}
