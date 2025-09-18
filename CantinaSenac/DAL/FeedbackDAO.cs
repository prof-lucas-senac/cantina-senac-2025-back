
class FeedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext context = new CantinaSenacContext();
    public void Atualizar(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        context.Feedbacks.Add(feedback);
        context.SaveChanges();
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