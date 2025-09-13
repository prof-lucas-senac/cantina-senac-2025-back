

class FeedbackDAO : IDAO<Feedback>
{
     public CantinaSenacContext contexto = new CantinaSenacContext();
    public void Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback objeto)
    {
        //Feedbacks.Add(objeto);
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
        return contexto.FeedBack.ToList();
    }
}