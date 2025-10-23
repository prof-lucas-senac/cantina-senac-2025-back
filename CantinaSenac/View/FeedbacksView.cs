static class FeedbacksView
{
    public static void Exibir()
    {
        List<Feedback> feedbacks;

        Console.Clear();
        System.Console.WriteLine("Cantina SENAC");
        System.Console.WriteLine("Lista de Feedbacks:");
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
        System.Console.WriteLine("4. Detalhar Feedback;");
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

    public static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        System.Console.WriteLine("Informe o Id do Feedback a ser atualizado:");
        feedback.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Insira o novo feedback:");
        feedback.Descricao = Console.ReadLine();

        new FeedbackController().AtualizarFeedback(feedback);

        System.Console.WriteLine("Feedback atualizado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
    public static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }

    public static void ExibirDialogoPostarFeedback()
    {
        System.Console.WriteLine("Poste o seu feedback:");
        string descricaoFeedback = Console.ReadLine();

        //new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

    public static void ExibirDialogoRemoverFeedback()
    {
        System.Console.Write("Digite o ID do feedback que deseja remover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            new FeedbackController().RemoverFeedback(id);
            System.Console.WriteLine("Feedback removido com sucesso.");
        }
        else
        {
            System.Console.WriteLine("Feedback não encontrado.\n");
        }

        System.Console.WriteLine("Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

    public static void ExibirDialogoDetalhesFeedback()
    {
        System.Console.WriteLine("Digite o ID do Feedback a ser detalhado: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Feedback? feedbackSelecionado = new FeedbackController().ListarPorId(id);

        if (feedbackSelecionado != null)
        {
            System.Console.WriteLine("Detalhes do feedback:\n");
            System.Console.WriteLine($"Id: {feedbackSelecionado.Id}");
            System.Console.WriteLine($"Conteúdo: {feedbackSelecionado.Descricao}");
            System.Console.WriteLine($"Data de Publicação: {feedbackSelecionado.DataPublicacao}\n");
        }
        else
        {
            System.Console.WriteLine("Feedback não encontrado.\n");
        }

        System.Console.WriteLine("Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
}