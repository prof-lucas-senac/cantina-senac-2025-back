public class FeedbackDAO : IDAO <Feedback>
{
    private static List<Feedback> Feedbacks = new List<Feedback>();

    public void Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        Feedbacks.Add(feedback);
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
        return Feedbacks;
    }
}