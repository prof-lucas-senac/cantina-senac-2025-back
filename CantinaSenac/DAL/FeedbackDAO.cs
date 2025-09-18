class FeedbackDAO : IDAO<Feedback>

{
    private CantinaSenacContext contexto = new CantinaSenacContext();
   // private static List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    public void Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }
    public void Cadastrar(Feedback objeto)
    {
      //  Feedbacks.Add(objeto);
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