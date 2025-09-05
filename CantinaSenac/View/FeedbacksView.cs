static class FeedbacksView
{
    public static void Exibir()
    {
        Console.WriteLine("Cantina Senac ");
        Console.WriteLine("pressione 1 para adicionar feedback e 2 para listar");
        string op = Console.ReadLine();

        while (op != "0")
        {
            switch (op)
            {
                case "1":
                    FeedbacksController.AdicionarFeedback();
                    Console.WriteLine("feedback adicionado com sucesso pressione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "2":
                    Console.WriteLine("Lista de Feedbacks:");
                    Console.WriteLine("======================================");
                    FeedbacksController.MostrarFeedbacks();
                    break;

                default:
                    Console.WriteLine("valor invalido");
                    break;
            }
            Console.WriteLine("pressione 1 para adicionar feedback, 2 para listar e 0 para encerrar");
            op = Console.ReadLine();
        }

    }
}