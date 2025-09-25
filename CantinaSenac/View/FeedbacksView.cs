using System.ComponentModel;

public class FeedbacksView
{
    private static FeedBackController feedBackController = new FeedBackController();
    public static void Exibir()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("¬¬¬¬¬ |Tela de Feedbacks| ¬¬¬¬¬");
            Console.WriteLine("[1] Adicionar Feedback");
            Console.WriteLine("[2] Listar Feedbacks");
            Console.WriteLine("[3] Alterar Feedback");
            Console.WriteLine("[4] Excluir Feedback");
            Console.WriteLine("[0] Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    AdicionarFeedBack();
                    break;
                case 2:
                    ListarFeedBacks();
                    break;
                case 3:
                    AlterarFeedBack();
                    break;
                case 4:
                    Console.WriteLine("Funcionalidade de excluir feedback ainda não implementada.");
                    break;
                case 0:
                    return;
                default:
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
    public static void AdicionarFeedBack()
    {
        FeedBack feedBack = new FeedBack();
        Console.Write(">>> Digite seu comentário: "); feedBack.Descricao = Console.ReadLine();
        Console.WriteLine();
        feedBackController.AdicionarFeedBack(feedBack);
        Console.WriteLine("Comentário adicionado com sucesso!");
        Console.ReadKey();
        Console.ReadKey();
    }
    public static void ListarFeedBacks()
    {
        Console.WriteLine("--- Lista de Feedbacks ---");
        feedBackController.ListarTodosFeedBacks();
        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        Console.WriteLine();
    }
    public static void AlterarFeedBack()
    {
        FeedBack feedBack = new FeedBack();
        Console.Write("Digite o ID do feedback que deseja alterar: ");
        feedBack.Id = int.Parse(Console.ReadLine());
        Console.Write("Digite o novo comentário: ");
        feedBack.Descricao = Console.ReadLine();
        feedBackController.AlterarFeedBack(feedBack);
    }
}