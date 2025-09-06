class FeedbackController
{

    public List<Feedback> ListarFeedbacks()
    {
        System.Console.WriteLine($"Abaixo segue os comentarios dos nossos alunos.");
        return new FeedbackDAO().ListarTodos();
    }

    public void ValidarCometario(string comentario)
    {
        if (string.IsNullOrWhiteSpace(comentario))
        {
            Console.WriteLine($"O comentario não pode ser vazio. Digite sua opnião ela éimportante para nós.");
        }
        else
        {
            Feedback novoFeeback = new Feedback()
            {
                Descricao = comentario

            };
            new FeedbackDAO().Cadastrar(novoFeeback);
            System.Console.WriteLine($"O comentario foi salvo com sucesso. Obrigado pelo FeedBack.");
        }
    }
}