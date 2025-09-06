static class LoginView
{
    public static void Exibir()
    {
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
            FeedbacksView.Exibir();
        }
        else
        {
            Console.WriteLine($"E-mail ou senha incorretos! Presione enter para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}