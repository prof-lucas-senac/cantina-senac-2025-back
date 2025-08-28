static class LoginView
{
    public static void Exibir()
    {
        string email = " ";
        string senha = " ";

        Console.WriteLine("Bem-vindo ao sistema CantinaSenac");

        System.Console.WriteLine("Digite seu email:");
        email = Console.ReadLine();

        System.Console.WriteLine("Digite sua senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine("Aluno autenticado com sucesso! Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Falha na autenticação. Verifique seu email ou senha" +
            "pressione enter para tentar novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}