using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

static class FeedbacksView
{

    public static void Exibir()
    {
        List<Feedback> feedbacks;

        Console.Clear();
        System.Console.WriteLine("Cantina SENAC");
        System.Console.WriteLine("Lista de Feedbacks:");
        feedbacks = new FeedbackController().ListarFeedbacks();
        if (feedbacks.Count > 0)
        {
            ListarFeedbacks(feedbacks);
        }
        else
        {
            System.Console.WriteLine("Nenhum Feedback foi postado ainda.");
        }


        CantinaSenacContext contexto = new CantinaSenacContext();
        Console.WriteLine($"Bem vindo ao menu FeedBack! Escolha uma das opções a seguir.");
        Console.WriteLine($"1- Adicionar Feedback.");
        Console.WriteLine($"2- Editar Feedback.");
        Console.WriteLine($"3- Excluir Feedback.");
        Console.WriteLine($"4- Listar detalhes do Feedback.");
        Console.WriteLine($"5- Sair do menu Feedback.");

        int opcaoMenu = Convert.ToInt32(Console.ReadLine());

        switch (opcaoMenu)
        {
            case 1:
                ExibirDialogoPostarFeedback();
                break;

            case 2:
                ExibirDialogoEditarFeedback();

                break;

            case 3:
                ExibirDialogodeExcluirFeedback();
                break;

            case 4:
                ExibirDialogorDetalhesDoFeedback();
                break;
            case 5:
                Console.WriteLine($"Fim doprograma");
                break;




        }
    }
    private static void ListarFeedbacks(List<Feedback> feedbacks)
    {
        foreach (Feedback feedback in feedbacks)
        {
            System.Console.WriteLine(feedback.Descricao);
        }
    }

    public static void ExibirDialogoPostarFeedback()
    {
        System.Console.WriteLine("Poste o seu feedback:");
        string descricaoFeedback = Console.ReadLine();

        new FeedbackController().PostarFeedback(descricaoFeedback);

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();
    }


    public static void ExibirDialogoEditarFeedback()
    {
        Feedback feedbackEditar = new Feedback();
        //FeedbackDAO feedBacDao = new FeedbackDAO();
        Console.WriteLine($"Insira o id do comentario que deseja editar.");
        int idEditar = Convert.ToInt32(Console.ReadLine());
        feedbackEditar.Id = idEditar;

        Console.WriteLine($"Insira um novo FeedBack.");
        feedbackEditar.Descricao = Console.ReadLine();

        new FeedbackController().AtualizarFeedbak(feedbackEditar);

        Console.WriteLine($"FeedBack Atualizado.");

        System.Console.WriteLine("Feedback postado com sucesso. Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();



    }

    public static void ExibirDialogodeExcluirFeedback()
    {
        Feedback feedbackExcluir = new Feedback();
        Console.WriteLine($"Informe o ID do Feedback que deseja excluir.");
        int idExcluir = Convert.ToInt32(Console.ReadLine());

        new FeedbackController().ExcluirFeedback(feedbackExcluir);

        System.Console.WriteLine(" Feedback excluido com sucesso.");
        System.Console.WriteLine(" Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();


    }

    private static void ExibirDialogorDetalhesDoFeedback()
    {
        Console.WriteLine($"Informe o ID do Feedback a ser exibido.");
        int id = Convert.ToInt32(Console.ReadLine());

        Feedback? feedbackSelecionado = new FeedbackController().ListarPorId(id);
        if (feedbackSelecionado != null)
        {
            Console.WriteLine($"Detalhes do Feedback!");
            Console.WriteLine($"Id: {feedbackSelecionado.Id} - Usuario: {feedbackSelecionado.Usuario} - Feedback: {feedbackSelecionado.Descricao} - Data de publicação: {feedbackSelecionado.DataPubicacao} ");
        }
        else
        {
            Console.WriteLine($"ID Feedback não encontrado.");
        }

        System.Console.WriteLine(" Pressione qualquer tecla para retornar à tela de Feedbacks.");
        Console.ReadKey();
        Exibir();

    }
}
