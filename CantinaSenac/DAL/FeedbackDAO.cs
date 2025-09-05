public class FeedbackDAO : IDAO<Feedback>
{
    public static List<Feedback> feedbacks = new List<Feedback>
    {
        new Feedback { Comentario = "Ótimo curso!",},
        new Feedback { Comentario = "Precisa melhorar o conteúdo.", }
    };

    public void Atualizar(Feedback objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Feedback objeto)
    {
        feedbacks.Add(objeto);
    }

    public string Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Feedback Listar(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Feedback> ListarTodos()
    {
        return feedbacks;
    }
}
