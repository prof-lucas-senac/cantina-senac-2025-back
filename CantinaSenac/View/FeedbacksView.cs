static class FeedbeckView
{
    public static void Exibir()
    {
        string feedbeck;

        Console.WriteLine("--- Tela de Feedback ---\n");

        System.Console.WriteLine("Descreva seu feedbeck: ");
        feedbeck = Console.ReadLine();

        System.Console.WriteLine("\n Obrigado pelo seu Feedbeck!");
        FeedbackController.Salvar(feedbeck);

        System.Console.WriteLine("\n Pressione Enter para sair...");
        System.Console.ReadKey();
    }
}