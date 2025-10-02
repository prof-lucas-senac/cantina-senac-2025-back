

class FeedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();
    public void Atualizar(Feedback objeto)
    {
        contexto.Feedbacks.Update(objeto);
        contexto.SaveChanges();
    }

    public void Cadastrar(Feedback objeto)
    {
        contexto.Feedbacks.Add(objeto);
        contexto.SaveChanges();
    }

    public void Excluir(Feedback objeto)
    {
        contexto.Feedbacks.Remove(objeto);
        contexto.SaveChanges();
    }

   public void Excluir(int id)
{
    Feedback feedback = contexto.Feedbacks.FirstOrDefault(f => f.Id == id);
    if (feedback != null)
    {
        contexto.Feedbacks.Remove(feedback);
        contexto.SaveChanges();
    }
    else
    {
        throw new Exception("Feedback não encontrado!");
    }
}

    public Feedback ListarPorId(int id)
    {
        return contexto.Feedbacks.FirstOrDefault(f => f.Id == id);
    
}

    public List<Feedback> ListarTodos()
    {
        return contexto.Feedbacks.ToList();
    }
}