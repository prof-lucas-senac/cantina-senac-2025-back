static class LoginView
{
    public static void Exibir()
    {
        string email = "", senha = "";
        Console.WriteLine("===============================");
        Console.WriteLine("Seja bem vindo a Cantina Senac");
        Console.WriteLine("===============================");
        Console.WriteLine("");
        Console.WriteLine("Insira seu Login e Senha");
        Console.WriteLine("");
        Console.WriteLine("Login:");
        email = Console.ReadLine();
        Console.WriteLine("Senha:");
        senha = Console.ReadLine();
        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Pressione ENTER para continuar");
            bool rep = true;
            while (rep == true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Enter)
                {
                    FeedbacksView.Exibir();
                    rep = false;
                }
            }
        }
        else
        {
            Console.WriteLine("login ou senha incorretos. Pressione ENTER par atentar novamente");
            bool rep = true;
            while (rep == true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Exibir();
                    rep = false;
                }
            }
        }
    }
}