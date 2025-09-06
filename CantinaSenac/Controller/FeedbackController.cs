public class FeedbackController
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
}