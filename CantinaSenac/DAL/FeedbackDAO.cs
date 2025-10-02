
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

    public Feedback ListarPorId(int id)
    {
        Feedback? feedback = null;
        feedback = context.Feedbacks.FirstOrDefault(x => x.Id == id);
        return feedback;
    }

    public List<Feedback> ListarTodos()
    {
        return context.Feedbacks.ToList();
    }
}