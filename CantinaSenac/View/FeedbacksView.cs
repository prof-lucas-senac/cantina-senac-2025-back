public static class FeedbacksView
{
    public static void Exibir()
    {




        Feedback feedback = new Feedback();


        System.Console.WriteLine("Tela de feedbacks");
        System.Console.WriteLine("Bem-vindo a tela de feedbacks do cantina Senac!");
        System.Console.WriteLine("Faça o seu feedback a seguir:");
        feedback.Descricao = Console.ReadLine();
        new FeedbackController().Criar(feedback);


        System.Console.WriteLine("Se quiser listar todos os feedbacks digite 1, se não digite qualquer outra coisa");
        int feedbackslistar = int.Parse(Console.ReadLine());

        if (feedbackslistar == 1)
        {
            new FeedbackController().Listar();
        }
        else
        {
            Console.ReadKey();
       }
        
  

        

        

     
    }
}