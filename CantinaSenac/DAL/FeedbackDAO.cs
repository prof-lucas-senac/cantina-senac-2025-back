
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

    public Feedback Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Feedback> ListarTodos()
    {
       return contexto.Feedbacks.ToList();
    }
}
