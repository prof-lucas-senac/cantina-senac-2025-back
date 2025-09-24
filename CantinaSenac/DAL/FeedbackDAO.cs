class FeedbackDAO : IDAO<Feedback>

{
    private CantinaSenacContext contexto = new CantinaSenacContext();
    // private static List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
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
    public Feedback Listar(int id)
    {
        return null;
    //    contexto.Feedbacks.tolist; 
    }
    public List<Feedback> ListarTodos()
    {
        return contexto.Feedbacks.ToList();
    }

}