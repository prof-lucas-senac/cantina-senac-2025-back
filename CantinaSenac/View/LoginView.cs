static class LoginView
{

    public static void Exibir()
    {
        string login = " ";
        string senha = " ";
        System.Console.WriteLine("Exibindo tela de login");
        System.Console.WriteLine("Bem-Vind@ ao Cantina Senac");
        System.Console.WriteLine("Por favor, insira suas credenciais para continuar.");

        System.Console.WriteLine("Email:");
        login = Console.ReadLine();
        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

 

        if (new LoginController().Autenticar(login, senha))
        {
            System.Console.WriteLine("Login realizado com sucesso!");
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Falha no Login");
            System.Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }

    }

}