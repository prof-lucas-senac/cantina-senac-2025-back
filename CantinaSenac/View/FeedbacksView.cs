static class FeedbacksView
{
    public static void Exibir()
    {
        List<Feedback> feedbacks;

        Console.Clear();
        System.Console.WriteLine("Cantina SENAC");
        System.Console.WriteLine("menu de opções:\n");

        feedbacks = new FeedbackController().ListarFeedbacks();
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            System.Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }
        System.Console.WriteLine("Menu de opções:\n");
        System.Console.WriteLine("1. Adicionar Feedback;");
        System.Console.WriteLine("2. Alterar Feedback;");
        System.Console.WriteLine("3. Excluir Feedback;");
        switch (Console.ReadLine())
        {
            case "1":
                ExibirDialogoPostarFeedback();
                break;
            case "2":
                ExibirDialogoAtualizarFeedback();
                break;
            case "3":
                ExibirDialogoRemoverFeedback();
                break;
            case "4":
                ExibirDialogoDetalhesFeedback();
                break;
        }
    }

    private static void ExibirDialogoRemoverFeedback()
    {
        Feedback feedbackselecionado = new Feedback();
        System.Console.WriteLine("informe o id do feedback que deseja remover:");
        feedbackselecionado.Id = Convert.ToInt32(Console.ReadLine()!);

        new FeedbackController().ExcluirFeedback(feedbackselecionado);

        System.Console.WriteLine("Feedback removido com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

    private static void ExibirDialogoDetalhesFeedback()
    {

        System.Console.WriteLine("Informe o id do feedback que deseja visualizar:");
        int Id = Convert.ToInt32(Console.ReadLine()!);

        Feedback feedbackselecionado = new FeedbackController().ListarPorId(Id);

        if (feedbackselecionado != null)
        {
            System.Console.WriteLine("====================//====================");
            System.Console.WriteLine("\nDetalhes do Feedback:\n");
            System.Console.WriteLine($"Id: {feedbackselecionado.Id}");
            System.Console.WriteLine($"Descrição: {feedbackselecionado.Descricao}");
            System.Console.WriteLine($"Data da publicação: {feedbackselecionado.DataPublicacao}");
            System.Console.WriteLine("Pressione qualquer tecla para retornar à tela de Feedbacks.");
            System.Console.WriteLine("====================//====================");
            Console.ReadKey();
            Exibir();
        }
        else
        {
            System.Console.WriteLine("Feedback não encontrado.\n ");
            System.Console.WriteLine("Pressione qualquer tecla para retornar à tela de Feedbacks.");
            Console.ReadKey();
            Exibir();
        }


    }
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }

    private static void ExibirDialogoPostarFeedback()
    {
        System.Console.WriteLine("Poste o seu feedback:");
        string descricaoFeedback = Console.ReadLine()!;

        new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
    private static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        System.Console.WriteLine("informe o id do feedback que deseja alterar:");
        feedback.Id = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("informe a nova descrição do feedback:");
        feedback.Descricao = Console.ReadLine()!;

        new FeedbackController().AtualizarFeedback(feedback);

        System.Console.WriteLine("Feedback alterado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
}