public class FeedbackDAO : IDAO <Feedback>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();

    public void Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        // Feedbacks.Add(feedback);
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
        return contexto.Feedbacks.ToList();
    }
}