// Classe estática responsável por exibir e cadastrar feedbacks no console
static class FeedBacksView
{
    // Método principal que exibe a lista de feedbacks e pergunta se o usuário deseja cadastrar um novo
    public static void Exibir(Aluno aluno)
    {
        Console.Clear(); // Limpa a tela do console
        Console.WriteLine("Cantina SENAC");
        Console.WriteLine("Lista de Feedbacks:\n");

        // Obtém todos os feedbacks cadastrados através do controller
        List<Feedback> feedbacks = new FeedbackController().ListarFeedbacks();

        // Se houver feedbacks, exibe a lista; senão, mostra mensagem de ausência
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks); // Chama método auxiliar para exibir os feedbacks
        }
        else
        {
            Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }

        // Pergunta ao usuário se deseja cadastrar um novo feedback
        Console.WriteLine("\nDeseja cadastrar um novo feedback? (s/n)");
        string opcao = Console.ReadLine().ToLower();

        // Se a resposta for "s", chama o método de cadastro
        if (opcao == "s")
        {
            CadastrarFeedback(aluno); // Passa o aluno logado como autor do feedback
        }
    }

    // Método auxiliar que exibe os feedbacks formatados
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Autor: {feedback.Usuario.NomeDoUsuario}");     // Exibe nome do autor
            Console.WriteLine($"Comentário: {feedback.Descricao}");            // Exibe texto do feedback
            Console.WriteLine($"Data: {feedback.DataPublicacao}");             // Exibe data de publicação
        }
        Console.WriteLine("-----------------------------------");
    }

    // Método que coleta dados do usuário e cadastra um novo feedback
    public static void CadastrarFeedback(Usuario usuario)
    {
        Console.Clear(); // Limpa a tela
        Console.WriteLine("=== Cadastrar Feedback ===\n");

        // Solicita o comentário do usuário
        Console.Write("Comentário: ");
        string descricaoFeedback = Console.ReadLine();

        // ⚠️ ERRO: Aqui está tentando passar uma string para um método que espera um objeto Feedback
        // Correção necessária: criar e preencher um objeto Feedback com os dados coletados

        new FeedbackController().Cadastrar(descricaoFeedback); // ❌ Isso causará erro de tipo (CS1503)

        Console.WriteLine("\nFeedback enviado com sucesso!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }
}
