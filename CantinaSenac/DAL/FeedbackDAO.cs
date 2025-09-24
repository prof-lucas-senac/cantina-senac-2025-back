class feedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();
    
    public static List<Feedback> feedbacks = new List<Feedback>();

    public static void Adicionar(Feedback feedback)
    {
        feedbacks.Add(feedback);
    }

    public static List<Feedback> Listar()
    {
    return feedbacks;
  }

    public void Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback objeto)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}