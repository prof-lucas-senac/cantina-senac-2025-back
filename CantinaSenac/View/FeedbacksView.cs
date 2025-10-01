using System.Diagnostics;

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
        System.Console.WriteLine("menu de opcoes");
        System.Console.WriteLine("1 - Adicionar Feedback");
        System.Console.WriteLine("2 - Alterar Feedback");
        System.Console.WriteLine("3 - Excluir Feedback");
        switch (Console.ReadLine())
        {
            case "1":
                ExibirDialogoPostarFeedback();
                break;
            case "2":
                ExibirDialogoAtualizarFeedback();
                break;
            case "3":
                ExibirDialogoExcluirFeedback();
                break;
            case "4":
                break;
        }

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

    private static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        System.Console.WriteLine("Digite o ID do feedback que deseja alterar:");
        feedback.Id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite a nova descrição do feedback:");
        feedback.Descricao = Console.ReadLine();
        new FeedbackController().AtualizarFeedback(feedback);

        System.Console.WriteLine("feedback alterado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }
    
    private static void ExibirDialogoExcluirFeedback()
{
    System.Console.WriteLine("Digite o ID do feedback que deseja excluir:");
    int id = int.Parse(Console.ReadLine());

    try
    {
        new FeedbackController().ExcluirFeedback(id);
        System.Console.WriteLine("Feedback excluído com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Erro ao excluir feedback: {ex.Message}");
    }

    Console.ReadKey();
    Exibir();
}

}