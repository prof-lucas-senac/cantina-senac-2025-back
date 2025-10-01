static class FeedbacksView
{
    public static void Exibir()
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
        Console.WriteLine("1-Criar feedback,2-Deletar feedback, 3-Modificar feedback");
        int escolha = int.Parse(Console.ReadLine());
        {
            string descricao;
            int avaliacao, id;
            switch (escolha)
            {
                case 1:
                    ExibirDialogoPostarFeedback();
                    break;
                case 2:
                    ExibirDialogoExcluirFeedback();
                    break;
                case 3:
                    ExibirDialogoEditarFeedback();
                    break;
            }
        }

        void ExibirDialogoPostarFeedback()
        {
            Feedback feedback = new Feedback();
            Console.WriteLine("Descrição:");
            feedback.Descricao = Console.ReadLine();
            Console.WriteLine("Avaliação:");
            feedback.Avaliacao = int.Parse(Console.ReadLine());
            FeedbackController.AdicionarFeedback(feedback);
            Console.WriteLine("Feedback postado com sucesso aperte ENTER para retornar a tela de feedbacks");
            bool rep = true;
            while (rep == true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Exibir();
                }
            }
        }
        void ExibirDialogoEditarFeedback()
        {
            Feedback feedback = new Feedback();
            Console.WriteLine("Id do feedback:");
            feedback.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nova Descrição:");
            feedback.Descricao = Console.ReadLine();
            Console.WriteLine("Nova Avaliação:");
            feedback.Avaliacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Feedback editado com sucesso aperte ENTER para retornar a tela de feedbacks");
            FeedbackController.EditarFeedback(feedback);
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
            {
                Exibir();
            }
        }
        void ExibirDialogoExcluirFeedback()
        {
            Console.WriteLine("Id do feedback:");
            int id = int.Parse(Console.ReadLine());
            Feedback fed = FeedbackController.ListarFeedback().Find(a => a.Id == id);
            FeedbackController.RemoverFeedback(fed);
            Console.WriteLine("Feedback excuido com sucesso aperte ENTER para retornar a tela de feedbacks");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
            {
                Exibir();
            }
        }
    }

}