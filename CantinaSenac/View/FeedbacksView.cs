static class FeedbacksView
{
    public static void Exibir()
    {
        List<Feedback> feedbacks;

        Console.Clear();
        System.Console.WriteLine("Cantina SENAC");
        System.Console.WriteLine("Lista de Feedbacks:");
        System.Console.WriteLine("==================================");
        feedbacks = new FeedbacksController().MostrarFeedbacks();

        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            System.Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }
        System.Console.WriteLine("==================================");
        System.Console.WriteLine("Menu de opções:\n");
        System.Console.WriteLine("1. Adicionar Feedback;");
        System.Console.WriteLine("2. Alterar Feedback;");
        System.Console.WriteLine("3. Excluir Feedback;");
        System.Console.WriteLine("4. Exibir detalhes de um Feedback;");
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

    private static void ExibirDialogoPostarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("---Adicione um feedback---");
        feedback.decricao = Console.ReadLine();

        try
        {
            new FeedbacksController().AdicionarFeedback(feedback);
        }
        catch (Exception)
        {
            Console.WriteLine("não foi possivel remover");
        }

        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("---Atualizar um feedback---");
        Console.WriteLine("para atualizar o feedback digite o id");
        feedback.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva o novo feedback");
        feedback.decricao = Console.ReadLine();

        try
        {
            new FeedbacksController().AtualizarFeedback(feedback);
        }
        catch (Exception)
        {
            Console.WriteLine("não foi possivel atualizar");
        }

        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoRemoverFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("---Remova um feedback---");
        Console.WriteLine("para remover o feedback digite o id");
        feedback.Id = int.Parse(Console.ReadLine());

        try
        {
            new FeedbacksController().RemoverFeedback(feedback);
        }
        catch (Exception)
        {
            Console.WriteLine("não foi possivel remover");
        }

        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoDetalhesFeedback()
    {
        Console.WriteLine("informe o Id do Feedback a ser exibido");
        int id = int.Parse(Console.ReadLine());

        Feedback? feedbackEscolhido = new FeedbacksController().ListarPorId(id);

        if (feedbackEscolhido != null)
        {
            System.Console.WriteLine("--detalhes do feedback--");
            Console.WriteLine($" ID: {feedbackEscolhido.Id}\n Feedback: {feedbackEscolhido.decricao}\n Data de publicação: {feedbackEscolhido.DataPublicacao}");
        }
        else
        {
            System.Console.WriteLine("feedback não encontrado\n");
        }
        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine($"{feedback.Id} || {feedback.decricao}");
        }
    }
}