static class FeedbackView
{
    public static void Exibir()
    {
        string feedback;

        Console.WriteLine("--- Tela de Feedback ---\n");

        System.Console.WriteLine("Descreva seu feedbeck: ");
        feedback = Console.ReadLine();

        System.Console.WriteLine("\n Obrigado pelo seu Feedbeck!");
        FeedbackController.Salvar(feedback);

        System.Console.WriteLine($"Lista de Feedbecks: \n" + feedback);

        System.Console.WriteLine("\n Pressione Enter para sair...");
        System.Console.ReadKey();
    }
}