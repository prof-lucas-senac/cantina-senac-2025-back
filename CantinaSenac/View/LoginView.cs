static class LoginView
{
    public static void Exibir()
    {
<<<<<<< HEAD
        string email;
        string senha;
        Console.WriteLine("bem vindo ao cantina senac");
        Console.WriteLine("login:");
        email = Console.ReadLine();
        Console.WriteLine("senha:");
=======
        string email = "";
        string senha = "";

        System.Console.WriteLine("Bem-vind@ ao Cantina Senac!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");
        System.Console.WriteLine("Email:");
        email = Console.ReadLine();
        System.Console.WriteLine("Senha:");
>>>>>>> master
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
<<<<<<< HEAD
            Console.WriteLine("Aluno autenticado com sucesso! pressione enter para continuar");
            Console.ReadKey();
            FeedbackView.Exibir();
        }
        else
        {
            Console.WriteLine("Login ou senha incorretos. Pressione enter para tentar novamente");
=======
            System.Console.WriteLine("Aluno autenticado com sucesso! Pressione Enter para continuar.");
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Login e/ou Senha incorretos. Pressione Enter para tentar novamente.");
>>>>>>> master
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}