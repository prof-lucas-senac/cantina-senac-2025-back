static class FeedbacksView
{
    public static void Exibir()
    {
        string op;
        do
        {
            Console.WriteLine("Lista de Feedbacks:");
            Console.WriteLine("======================================");
            new FeedbacksController().MostrarFeedbacks();

            Console.WriteLine("\nCantina Senac\n ");
            Console.WriteLine("pressione: \n[1] para adicionar feedback \n[2] para remover \n[3] para atualizar\n[4] Exibir detalhes do Feedback \n[0] para sair");
            op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    break;
                case "1":
                    ExibirDialogoAdicionarFeedback();
                    break;
                case "2":
                    ExibirDialogoRemoverFeedback();
                    break;
                case "3":
                    ExibirDialogoAtualizarFeedback();
                    break;
                case "4":
                    ExibirDialogoDetalhesFeedback();
                    break;
                default:
                    Console.WriteLine("valor invalido");
                    break;
            }
        } while (op != "0");
    }

    private static void ExibirDialogoAdicionarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("---Adicione um feedback---");
        feedback.decricao = Console.ReadLine();

        try
        {
            new FeedbacksController().AdicionarFeedback(feedback);
        }
        catch (Exception)
        {
            Console.WriteLine("não foi possivel remover");
        }

        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoAtualizarFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("---Atualizar um feedback---");
        Console.WriteLine("para atualizar o feedback digite o id");
        feedback.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva o novo feedback");
        feedback.decricao = Console.ReadLine();

        try
        {
            new FeedbacksController().AtualizarFeedback(feedback);
        }
        catch (Exception)
        {
            Console.WriteLine("não foi possivel atualizar");
        }

        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoRemoverFeedback()
    {
        Feedback feedback = new Feedback();
        Console.WriteLine("---Remova um feedback---");
        Console.WriteLine("para remover o feedback digite o id");
        feedback.Id = int.Parse(Console.ReadLine());

        try
        {
            new FeedbacksController().RemoverFeedback(feedback);
        }
        catch (Exception)
        {
            Console.WriteLine("não foi possivel remover");
        }

        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoDetalhesFeedback()
    {
        Console.WriteLine("informe o Id do Feedback a ser exibido");
        int id = int.Parse(Console.ReadLine());

        Feedback? feedbackEscolhido = new FeedbacksController().ListarPorId(id);

        if (feedbackEscolhido != null)
        {
            System.Console.WriteLine("--detalhes do feedback--");
            Console.WriteLine($" ID: {feedbackEscolhido.Id}\n Feedback: {feedbackEscolhido.decricao}\n Data de publicação: {feedbackEscolhido.DataPublicacao}");
        }
        else
        {
            System.Console.WriteLine("feedback não encontrado\n");
        }
        Console.WriteLine("pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}