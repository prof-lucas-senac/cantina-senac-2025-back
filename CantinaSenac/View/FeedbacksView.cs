static class FeedbacksView
{
    public static void Exibir()
    {
        Console.WriteLine("=================");
        Console.WriteLine("Tela de feedbacks");
        Console.WriteLine("=================");
        foreach (Feedback feedback in FeedbackController.ListarFeedback())
        {
            Console.WriteLine("");
            Console.WriteLine(feedback.Id);
            Console.WriteLine(feedback.Descricao);
            Console.WriteLine(feedback.Avaliacao);
        }
        Console.WriteLine("1-Criar feedback,2-Deletar feedback, 3-Modificar feedback, 4-Sair");
        int escolha = int.Parse(Console.ReadLine());
        {
            string descricao;
            int avaliacao, id;
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Descrição:");
                    descricao = Console.ReadLine();
                    Console.WriteLine("Avaliação:");
                    avaliacao = int.Parse(Console.ReadLine());
                    FeedbackController.AdicionarFeedback(descricao, avaliacao);
                    break;
                case 2:
                    Console.WriteLine("Id do feedback:");
                    id = int.Parse(Console.ReadLine());
                    FeedbackController.RemoverFeedback(id);
                    break;
                case 3:
                    Console.WriteLine("Id do feedback:");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Descrição:");
                    descricao = Console.ReadLine();
                    Console.WriteLine("Avaliação:");
                    avaliacao = int.Parse(Console.ReadLine());
                    FeedbackController.EditarFeedback(descricao,avaliacao, id);
                    break;
            }
        }
    }
}