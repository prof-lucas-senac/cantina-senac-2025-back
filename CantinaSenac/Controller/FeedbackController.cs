class FeedbackController
{

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
    public void DeletarFeedback(Feedback feedback)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        feedbackDAO.Excluir(feedback);
    }
    public Feedback listarPorId(int id)
    {
        FeedbackDAO feedbackDAO = new FeedbackDAO();
        if (feedbackDAO != null){  
            return feedbackDAO.ListarPorId(id);
        }else{
            return null;
        }
        

     }

}