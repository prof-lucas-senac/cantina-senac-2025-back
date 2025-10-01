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
        contexto.Feedbacks.Update(objeto);
        contexto.SaveChanges();
    }

    public void Excluir(Feedback objeto)
    {
        contexto.Feedbacks.Remove(objeto);
        contexto.SaveChanges();
    }

    public void Remover(int id)
    {
        var feedback = contexto.Feedbacks.FirstOrDefault(fb => fb.Id == id);
        if (feedback != null)
        {
            contexto.Feedbacks.Remove(feedback);
            contexto.SaveChanges();
            Console.WriteLine($"\nFeedback com ID {id} removido do banco de dados.");
        }
        else
        {
            Console.WriteLine($"\nFeedback com ID {id} não encontrado no banco de dados.");
        }
    }

    public Feedback Listar(int id)
    {
        return contexto.Feedbacks.FirstOrDefault(fb => fb.Id == id);
    }

    public List<Feedback> ListarTodos()
    {
        return contexto.Feedbacks.ToList();
    }
}
