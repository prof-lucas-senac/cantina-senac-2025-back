
class FeedbackDAO: IDAO<Feedback>
{

    // public static List<Feedback> feedbacks = new List<Feedback>();
    private CantinaSenacContext contexto = new CantinaSenacContext();
    public void Atualizar(Feedback feedback)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback feedback)
    {
        contexto.Feedbacks.Add(feedback);
        contexto.SaveChanges();

    }
 
    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    // public Feedback Listar(int id)
    // {
    //     // foreach (var item in feedbacks)
    //     // {
    //     //     if (item.Id == id)
    //     //     {
    //     //         return item;
    //     //     }
    //     // }
    //     // throw new Exception("Feedback não encontrado");
    // }

    public Feedback listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Feedback> ListarTodos()
    {
       return contexto.Feedbacks.ToList();
    }
}
