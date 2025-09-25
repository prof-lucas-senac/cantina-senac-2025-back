class FeedbackController
{
    public void Adicionar(Feedback feedback)
    {
        new FeedbackDAO().Cadastrar(feedback);
    }
    public List<Feedback> Listar()
    {
        FeedbackDAO feedback = new FeedbackDAO();
        List<Feedback> lista = feedback.ListarTodos();
        foreach (var Feedback in lista)
        {
            System.Console.WriteLine($"ID: {Feedback.Id} - Descrição: {Feedback.Descricao}");
        }
        return lista;
    }

    public void PostarFeedback(string descricaoFeedback)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        Feedback feedback = new Feedback();
        feedback.Descricao = descricaoFeedback;
        feedback.UsuarioId = 1;
        feedback.dataPostagem = DateTime.Now;
        feedbackDAO.Cadastrar(feedback);
    }
    public void AtualizarFeedback(Feedback feedback, string novaDescricao)
{
    FeedbackDAO feedbackDAO = new FeedbackDAO();
  
    if (feedback != null)
    {
        feedback.Descricao = novaDescricao;
        feedback.dataPostagem = DateTime.Now; 
        feedbackDAO.Atualizar(feedback);
    }
}
}