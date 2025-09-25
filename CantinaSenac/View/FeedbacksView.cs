static class FeedbacksView
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("--- Tela de Feedback ---\n");


        Console.WriteLine("Digite seu feedback sobre a cantina:");
        string feedback = Console.ReadLine();

        Console.WriteLine("\nObrigado pelo seu feedback!");

        FeedbackController.Salvar(feedback);

        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadKey();

        System.Console.WriteLine("--- Menu de Opções ---\n");
        System.Console.WriteLine("1. Adicionar Feedback:\n");
        System.Console.WriteLine("2. Alterar Feedback:\n");
        System.Console.WriteLine("3. Excluir Feedback:\n");

        switch (System.Console.ReadLine()) {
            case "1":
                Exibir();
                break;
            case "2":
                break;
            case "3":
                break;
        }
    }
}
 
