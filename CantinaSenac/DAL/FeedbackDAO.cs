

using Pomelo.EntityFrameworkCore.MySql.Metadata.Internal;

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
        contexto.Feedbacks.Add(objeto);
        contexto.SaveChanges();
    }

    public void Excluir(Feedback objeto)
    {
        contexto.Feedbacks.Remove(objeto);
        contexto.SaveChanges();
    }

    public Feedback ListarPorId(int id)
    {
        return null;
    }

    public List<Feedback> ListarTodos()
    {
        return contexto.Feedbacks.ToList();
    }
}