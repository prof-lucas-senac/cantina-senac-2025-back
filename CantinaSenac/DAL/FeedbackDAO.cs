
class FeedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext context = new CantinaSenacContext();
    public void Atualizar(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        // feedbacks.Add(feedback);
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
        return context.Feedbacks.ToList();
    }
}