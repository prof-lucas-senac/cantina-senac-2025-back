
class FeedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext context = new CantinaSenacContext();
    public void Atualizar(Feedback feedback)
    {
        context.Feedbacks.Update(feedback);
        context.SaveChanges();
    }

    public void Cadastrar(Feedback feedback)
    {
        context.Feedbacks.Add(feedback);
        context.SaveChanges();
    }

    public void Excluir(Feedback objeto)
    {
        context.Feedbacks.Remove(objeto);
        context.SaveChanges();
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