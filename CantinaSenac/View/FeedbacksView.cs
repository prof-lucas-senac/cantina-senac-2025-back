using System.ComponentModel;

public class FeedbacksView
{
    private static FeedBackController feedBackController = new FeedBackController();
    public static void Exibir()
    {
        Console.WriteLine("¬¬¬¬¬ |Tela de Feedbacks| ¬¬¬¬¬");
        if (new FeedBackController().VerificarSeTemFeedBacks())
        {
            ListarFeedBacks();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Não há comentários!");
            Console.WriteLine();
            Console.WriteLine("Deseja adicionar algum comentário? \n[1]Sim [2]Não");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (opcao)
            {
                case 1:
                    AdicionarFeedBack();
                    break;
                case 2:
                    Console.WriteLine("Não há feedbacks!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            ListarFeedBacks();
        }
    }
    public static void AdicionarFeedBack()
    {
        FeedBack feedBack = new FeedBack();
        Console.Write(">>> Digite seu comentário: "); feedBack.Descricao = Console.ReadLine();
        Console.WriteLine();
        feedBackController.AdicionarFeedBack(feedBack);
    }
    public static void ListarFeedBacks()
    {
        Console.WriteLine("--- Lista de Feedbacks ---");
        feedBackController.ListarTodosFeedBacks();
        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        Console.WriteLine();
    }
}