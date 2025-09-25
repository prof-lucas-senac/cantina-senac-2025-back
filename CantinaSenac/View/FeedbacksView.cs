using System.Runtime.CompilerServices;

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
        Console.WriteLine("=== MENU DE FEEDBACKS ===\n");
        Console.WriteLine("1 - Adicionar Feedback");
        Console.WriteLine("2 - Alterar Feedback");
        Console.WriteLine("3 - Excluir Feedback");
        switch (System.Console.ReadLine())
        {
            case "1":
                ExibirDialogoPostarFeedback();
                break;
            case "2":
                ExibirDialogoAtualizarFeedback();
                break;
            case "3":
                break;
        }
        ExibirDialogoPostarFeedback();
    }

    public static void ExibirDialogoPostarFeedback()
    {
        System.Console.WriteLine("Poste o seu feedback:");
        string descricaoFeedback = Console.ReadLine()!;

        new FeedbackController().PostarFeedback(descricaoFeedback);

        Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }

    public static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("Informe id do Feedback: ");
        feedback.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe nova descrição do Feedback: ");
        feedback.Descricao = Console.ReadLine()!;

        new FeedbackController().AtualizarFeedback(feedback);

        Console.WriteLine("Feedback atualizadio com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadLine();
        Exibir();
    }
    
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            Console.WriteLine(feedback.Descricao);
        }
    }
}