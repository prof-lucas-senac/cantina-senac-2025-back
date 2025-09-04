public class FeedbacksView
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("--- Tela de Feedback ---\n");


        Console.WriteLine("Digite seu feedback sobre a cantina:");
        string feedback = Console.ReadLine();

        Console.WriteLine("\nObrigado pelo seu feedback!");

        FeedbackController.Salvar(feedback); 

        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadKey();
    }
}