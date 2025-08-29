static class LoginView
{
    public static void Exibir()
    {
<<<<<<< HEAD
        Console.WriteLine("Bem-Vindo a Cantina Senac!");
        Console.WriteLine("-----------||-------------");
        Console.WriteLine("Digite suas credencias");
        Console.Write("E-mail: ");
        string email = Console.ReadLine();
        Console.Write("Senha: ");
        string senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine($"Aluno autenticado com sucesso!. Presione enter para continuar.");
            Console.ReadKey();
            FeedbacksViews.Exibir();
        }
        else
        {
            Console.WriteLine($"E-mail ou senha incorretos! Presione enter para tentar novamente.");
=======
        string email = "";
        string senha = "";

        System.Console.WriteLine("Bem-vind@ ao Cantina Senac!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");
        System.Console.WriteLine("Email:");
        email = Console.ReadLine();
        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
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