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
    }s

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

    string IDAO<Feedback>.Excluir(int id)
    {
       contexto.Feedbacks.Remove();
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
