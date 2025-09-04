using System.ComponentModel;

public class FeedbacksView
{
    public static void Exibir()
    {
        Console.WriteLine("¬¬¬¬¬ |Tela de Feedbacks| ¬¬¬¬¬");
        if (new FeedBackController().VerificarSeTemFeedBacks())
        {
            ListarFeedBacks();
        }
        else
        {
            Console.WriteLine("Não há comentários!");
            Console.WriteLine("Deseja adicionar algum comentário? \n[1]Sim [2]Não");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Adicionar();
                    break;
                case 2:
                    break;
            }
        }
        ListarFeedBacks();
    }
    public static void Adicionar()
    {
        FeedBackController feedBackController = new FeedBackController();
        feedBackController.AdicionarFeedBack();
    }
    public static void ListarFeedBacks()
    {
        Console.WriteLine("--- Lista de Feedback ---");
        List<FeedBack> feedBacks = new FeedBackDAO().ListarFeedBacks();
        foreach (FeedBack feedBack in feedBacks)
        {
            Console.WriteLine(feedBack.Descricao);
        }
    }
}