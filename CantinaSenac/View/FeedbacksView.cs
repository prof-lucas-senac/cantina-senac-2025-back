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
        Console.WriteLine("Menu de opções:\n");
        Console.WriteLine("1- Adicionar Feedback;\n");
        Console.WriteLine("2- Alterar Feedback;\n");
        Console.WriteLine("3- Excluir Feedback;\n");
        switch (Console.ReadLine())
        {
            case "1":
                ExibirDialogoPostarFeedback();
                break;
            case "2":
                ExibirDialogoPostarFeedback();
                break;
            case "3":
                break;
        } ExibirDialogoPostarFeedback();
    }

    private static void ExibirDialogoPostarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("Informe o Id do Feedback a ser atualizado:");
        feedback.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o novo Feedback: ");
        feedback.Descricao = Console.ReadLine();

        new FeedbackController().AtualizarFeedback(feedback);

        Console.Write("Feedback atualizado com sucesso! Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }
}