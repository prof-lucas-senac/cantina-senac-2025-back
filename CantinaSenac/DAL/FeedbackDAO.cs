
class FeedbackDAO: IDAO<Feedback>
{

    // public static List<Feedback> feedbacks = new List<Feedback>();
    private CantinaSenacContext contexto = new CantinaSenacContext();
    public void Atualizar(Feedback feedback)
    {
        contexto.Feedbacks.Update(feedback);
        contexto.SaveChanges();
    }

    public void Cadastrar(Feedback feedback)
    {
        contexto.Feedbacks.Add(feedback);
        contexto.SaveChanges();

    }
 
    public void Excluir(Feedback feedback)
    {
        contexto.Feedbacks.Remove(feedback);
        contexto.SaveChanges();
    }

    public Feedback ListarPorId(int id)
    {
        Feedback feedback = null;
        feedback = contexto.Feedbacks.FirstOrDefault(feedback => feedback.Id == id);
        return feedback;
    }

    public List<Feedback> ListarTodos()
    {
       return contexto.Feedbacks.ToList();
    }
}
