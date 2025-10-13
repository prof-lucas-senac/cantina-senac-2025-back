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
            Console.WriteLine("[2] Listar todos Feedbacks");
            Console.WriteLine("[3] Alterar Feedback");
            Console.WriteLine("[4] Excluir Feedback");
            Console.WriteLine("[5] Ver detalhes de um Feedback");
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
                    ExcluirFeedBack();
                    break;
                case 5:
                    ListarUnicoFeedBack();
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
    }
    public static void ListarFeedBacks()
    {
        Console.WriteLine("--- Lista de Feedbacks ---");
        feedBackController.ListarTodosFeedBacks();
        foreach (FeedBack feedBack in feedBackController.ListarTodosFeedBacks())
        {
            Console.WriteLine($"Decrição: {feedBack.Descricao}");
            Console.WriteLine("ID: " + feedBack.Id);
            Console.WriteLine("----------");
        }
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
    public static void ExcluirFeedBack()
    {
        FeedBack feedBack = new FeedBack();
        Console.Write("Digite o ID do feedback que deseja excluir: ");
        feedBack.Id = int.Parse(Console.ReadLine());
        feedBackController.ExcluirFeedBack(feedBack);
        Console.WriteLine("Feedback excluído com sucesso!");
    }
    private static void ListarUnicoFeedBack()
    {
        Console.Write("Digite o ID do feedback que deseja exibir detalhes: ");
        int id = Convert.ToInt32(Console.ReadLine());


        FeedBack feedbackSelecionado = new FeedBackController().ListarPorId(id);
        
        if (feedbackSelecionado != null)
        {
            Console.WriteLine($"ID do Feedback: {feedbackSelecionado.Id}");
            Console.WriteLine($"Descrição: {feedbackSelecionado.Descricao}");
            Console.WriteLine($"Data de Publicação: {feedbackSelecionado.DataPublicacao}");
            Console.WriteLine($"ID do Usuário: {feedbackSelecionado.UsuarioId}");
        }
        else
        {
            Console.WriteLine("Feedback não encontrado!");
        }
    }
}