static class FeedbacksView
{
    public static void Exibir()
    {
        string op = "";
        do
        {
            Console.WriteLine("Lista de Feedbacks:");
            Console.WriteLine("======================================");
            new FeedbacksController().MostrarFeedbacks();

            Console.WriteLine("Cantina Senac ");
            Console.WriteLine("pressione: \n[1] para adicionar feedback \n[2] para remover \n[3] para atualizar \n[0] para sair");
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
        catch (System.Exception)
        {
            Console.WriteLine("não foi possivel remover");
            throw;
        }
        

        Console.WriteLine("feedback adicionado com sucesso pressione enter para continuar");
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
        catch (System.Exception)
        {
            Console.WriteLine("não foi possivel atualizar");
            throw;
        }

        Console.WriteLine("feedback atualizado com sucesso pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private static void ExibirDialogoRemoverFeedback()
    {
        Console.WriteLine("---Remova um feedback---");
        Console.WriteLine("para remover o feedback digite o id");
        int id = int.Parse(Console.ReadLine());

        try
        {
            new FeedbacksController().RemoverFeedback(id);
        }
        catch (System.Exception)
        {
            Console.WriteLine("não foi possivel remover");
            throw;
        }
        Console.WriteLine("feedback removido com sucesso pressione enter para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}