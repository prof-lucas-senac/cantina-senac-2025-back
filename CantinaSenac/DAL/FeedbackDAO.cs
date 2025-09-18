

class FeedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();


    public void Cadastrar(Feedback objeto)
    {
        contexto.Feedbacks.Add(objeto);
        contexto.SaveChanges();
    }
    public void Atualizar(Feedback objeto)
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

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }
}