static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";


        Console.Clear();
        System.Console.WriteLine($"\t=== Bem Vindo@ ao ===\n\t=== Cantina SENAC! ===");
        System.Console.WriteLine($"\tDigite seu email:");
        email = Console.ReadLine();
        System.Console.WriteLine();
        System.Console.WriteLine($"\tDigite sua senha:");
        senha = Console.ReadLine();
        System.Console.WriteLine();

        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine($"Aluno autenticado com sucesso!");
            System.Console.WriteLine($"Pressione uma tecla para continuar");
            Console.ReadKey();
            Feedbacksview.Exibir();
        }
        else
        {
            System.Console.WriteLine($"Email ou senha incorretos");
            System.Console.WriteLine("Pressione Enter para tentar novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }

    }
}