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
        throw new NotImplementedException();
    }

    public void Excluir(Feedback objeto)
    {
        contexto.Feedbacks.Remove(objeto);
        contexto.SaveChanges();
    }

    public Feedback Listar(int Id)
    {
        throw new NotImplementedException();
    }


    public List<Feedback> ListarTodos()
    {
        throw new NotImplementedException();
    }

    void IDAO<Feedback>.Cadastrar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    void IDAO<Feedback>.Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    List<Feedback> IDAO<Feedback>.ListarTodos()
    {
        throw new NotImplementedException();
    }

    Feedback IDAO<Feedback>.Listar(int Id)
    {
        throw new NotImplementedException();
    }
}
