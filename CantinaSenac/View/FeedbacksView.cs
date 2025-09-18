static class FeedbacksView
{
    public static void Exibir(Aluno aluno)
    {
        bool rep = true;
        while (rep)
        {
            Console.Clear();
            Console.WriteLine("=================");
            Console.WriteLine("Tela de feedbacks");
            Console.WriteLine("=================");
            if (FeedbackController.ListarFeedback().Count > 0)
            {
                foreach (Feedback feedback in FeedbackController.ListarFeedback())
                {
                    Console.WriteLine("");
                    Console.WriteLine("ID:" + feedback.Id);
                    if (feedback.Descricao != null)
                    {
                        Console.WriteLine(feedback.Descricao);
                    }
                    Console.WriteLine("Nota:" + feedback.Avaliacao);
                }
            }
            else
            {
                Console.WriteLine("Nenhum Feedback encontrado");
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
                        FeedbackController.AdicionarFeedback(descricao, avaliacao, aluno);
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
                        FeedbackController.EditarFeedback(descricao, avaliacao, id);
                        break;
                    case 4:
                        rep = false;
                        break;
                }
            }
        }
    }
    
}