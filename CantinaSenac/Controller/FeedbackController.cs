static class FeedbackController
{

    private static FeedbackDAO dao = new FeedbackDAO();
    private static List<Feedback> _feedbacks = new List<Feedback>();


    public static void Salvar(string objeto)
    {
        if (string.IsNullOrWhiteSpace(objeto))
        {
            Console.WriteLine("\nNada foi informado. Feedback não salvo.");
            return;
        }

        var novo = new Feedback()
        {
            Id = _feedbacks.Count + 1,
            Descricao = objeto
        };

        _feedbacks.Add(novo);
        Console.WriteLine("\nFeedback salvo com sucesso!");
    }

    public static List<Feedback> Listar()
    {
        return _feedbacks;
    }

    public static Feedback BuscarPorId(int id)
    {
        return _feedbacks.FirstOrDefault(fb => fb.Id == id);
    }

    public static void Atualizar(Feedback feedbackAtualizado)
    {
        var index = _feedbacks.FindIndex(fb => fb.Id == feedbackAtualizado.Id);
        if (index != -1)
        {
            _feedbacks[index] = feedbackAtualizado;
        }
    }

    public static void PostarFeedback(string descricaoFeedback)
    {
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.DataPublicacao = DateTime.Now;
        dao.Cadastrar(feedback);
    }
    public static void AtualizarFeedback(Feedback feedback)
    {
        feedback.DataPublicacao = DateTime.Now;
        feedback.UsuarioId = 1;
        dao.Atualizar(feedback);

    }

  public static void Remover(int id)
{
    var feedback = BuscarPorId(id);
    if (feedback == null)
    {
        Console.WriteLine($"\nFeedback com ID {id} não encontrado.");
        return;
    }

    _feedbacks.Remove(feedback);
    dao.Remover(id); 
    Console.WriteLine($"\nFeedback com ID {id} removido com sucesso.");
}
}


