// Classe responsável por controlar as operações relacionadas à entidade Feedback
// Atua como intermediária entre a camada de apresentação (views) e a camada de dados (DAO)
class FeedbackController
{

    private FeedbackDAO dao = new FeedbackDAO();
    // Retorna todos os feedbacks cadastrados no sistema
    public List<Feedback> ListarFeedbacks()
    {
        return new FeedbackDAO().ListarTodos();
    }

    // Cadastra um novo feedback com base no objeto recebido
    public void Cadastrar(Feedback feedback)
    {
        new FeedbackDAO().Cadastrar(feedback);
    }

    // Atualiza um feedback existente com os dados fornecidos
    public void Atualizar(Feedback feedback)
    {
        new FeedbackDAO().Atualizar(feedback);
    }

    // Exclui um feedback com base no ID fornecido
    public void Excluir(int id)
    {
        new FeedbackDAO().Excluir(id);
    }

    // Retorna um feedback específico pelo ID (opcional, útil para edição)
    public Feedback BuscarPorId(int id)
    {
        return new FeedbackDAO().ListarPorId(id);
    }

    public Feedback ListarPorId(int id)
    {
        Feedback feedback = dao.ListarPorId(id);

        if (feedback != null)
        {
            return feedback;
        }
        else
        {
            return null;
        }
    }
}
