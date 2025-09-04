class FeedbackController
{
    public void Criar(Feedback feedback)
    {
        new FeedbackDAO().Cadastrar(feedback);

    }

    public void Listar()
    {
        FeedbackDAO feedbackk = new FeedbackDAO();
        List<Feedback> lista = feedbackk.ListarTodos();

        foreach (var feedback in lista)
        {
            System.Console.WriteLine($"ID =  {feedback.Id} e Descrição: = {feedback.Descricao}");
        }
    }
}