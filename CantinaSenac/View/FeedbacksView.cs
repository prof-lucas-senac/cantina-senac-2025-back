static class FeedbacksView
{
    public static void Exibir()
    {
        FeedbackController controller = new FeedbackController();

        while (true)
        {
            List<Feedback> feedbacks = controller.Listar(); 

            Console.Clear();
            Console.WriteLine("LISTA DE FEEDBACKS");
            if (feedbacks.Count == 0)
            {
                Console.WriteLine("Nenhum feedback cadastrado ainda.");
            }
            else
            {
                controller.Listar();
            }
            
            Console.WriteLine("\n O que deseja fazer?");
            Console.WriteLine("1 - Cadastrar novo feedback");
            Console.WriteLine("2 - Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Criar();
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Obrigado pelo seu feedback! Pressione Enter para continuar.");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Pressione Enter para continuar.");
                Console.ReadKey();
            }
        }
    }

    private static void Criar()
    {
        // Feedback feedback = new Feedback();
        Console.WriteLine("Por favor, deixe seu feedback sobre a cantina:");
        string descricaoFeedback = Console.ReadLine();

        new FeedbackController().PostarFeedback(descricaoFeedback);

        Console.WriteLine("Feedback cadastrado com sucesso! Pressione Enter para continuar");
        Console.ReadKey();
    }
}
