// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        
        AlunoDAO.alunos.Add(new Aluno()
        {
            Id = 101,
            Email = "aluno@senac.br",
            Senha = "aluno"
        });

        bool continuar = true;
        while (continuar)
        {
           
            LoginView.Exibir();
            
            FeedbackView feedbackView = new FeedbackView();
            feedbackView.ExibirFeedbacks();
            
            FeedbackController controller = new FeedbackController();
            var feedbacksAtualizados = controller.ListarFeedbacks();

            Console.WriteLine("\n--- Feedbacks Atualizados ---");
            foreach (var f in feedbacksAtualizados)
            {
                Console.WriteLine($"Comentário: {f.Comentario}");
            }
           
            Console.Write("\nDeseja voltar ao início? (s/n): ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() != "s")
            {
                continuar = false;
                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear(); 
            }
        }
    }
}

