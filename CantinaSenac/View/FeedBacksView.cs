static class FeedBacksView
{
    public static void Exibir(Aluno aluno)
    {
        Console.Clear();
        Console.WriteLine("Cantina SENAC");
        Console.WriteLine("Lista de Feedbacks:\n");

        List<Feedback> feedbacks = new FeedbackController().ListarFeedbacks();
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }

        Console.WriteLine("\nDeseja cadastrar um novo feedback? (s/n)");
        string opcao = Console.ReadLine().ToLower();

        if (opcao == "s")
        {
            CadastrarFeedback(aluno);
        }
    }

    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Autor: {feedback.usuario.NomeDoUsuario}");
            Console.WriteLine($"Nota: {feedback.Nota}");
            Console.WriteLine($"Comentário: {feedback.Descricao}");
            Console.WriteLine($"Data: {feedback.DataPublicacao}");
        }
        Console.WriteLine("-----------------------------------");
    }

    public static void CadastrarFeedback(Usuario usuario)
    {
        Console.Clear();
        Console.WriteLine("=== Cadastrar Feedback ===\n");

        Console.Write("Comentário: ");
        string comentario = Console.ReadLine();

        Console.Write("Nota (1 a 5): ");
        int nota = int.Parse(Console.ReadLine());

        var feedback = new Feedback(comentario, nota, usuario);

        new FeedbackController().Cadastrar(feedback);

        Console.WriteLine("\nFeedback enviado com sucesso!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }
}
