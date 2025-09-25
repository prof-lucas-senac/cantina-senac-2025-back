public static class FeedbacksView
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

        System.Console.WriteLine("1. Adicionar Feedback; ");
        System.Console.WriteLine("2. Alterar Feedback;");
        System.Console.WriteLine("3. Excluir Feedback");
        int escolha = Convert.ToInt32(Console.ReadLine());
        if (escolha == 1)
        {
            ExibirDialogoPostarFeedback();
        }

        else if (escolha == 2)
        {
            ExibirDialogoEditarFeedback();
        }

        else if (escolha == 3)
        {
           ExibirDialogoExcluirFeedback();
        }
        else {}
    }

    private static void ListarFeedbacks(List<Feedback> feedbacks)
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

        new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }


    public static void ExibirDialogoExcluirFeedback()
    {
         Feedback feedback = new Feedback();

        System.Console.WriteLine("Exclua o seu feedback:");
        System.Console.WriteLine("Digite o id do feedback a ser excluido:");
        feedback.Id = Convert.ToInt32(Console.ReadLine());

        new FeedbackController().ExcluirFeedback(feedback);

        System.Console.WriteLine("Feedback excluido com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
    
     public static void ExibirDialogoEditarFeedback()
    {
         Feedback feedback = new Feedback();

        System.Console.WriteLine("Edite o seu feedback:");
        System.Console.WriteLine("Digite o id do feedback a ser editado:");
        feedback.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite as alterações no feedback");
        feedback.Descricao = Console.ReadLine();

        new FeedbackController().EditarFeedback(feedback);

        System.Console.WriteLine("Feedback editado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

}