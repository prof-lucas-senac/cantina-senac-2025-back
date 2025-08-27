static class LoginView
{
    public static void Exibir()
    {
        System.Console.WriteLine("====================//====================");
        Console.WriteLine("Bem-vindo ao sistema de login!\n");
        Console.WriteLine("Digite seu email: ");
        string email = Console.ReadLine()!;
        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine()!;
        System.Console.WriteLine("====================//====================");

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Login bem-sucedido! pressione Enter para continuar.");
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
            Console.WriteLine("Login falhou. Verifique suas credenciais. Pressione Enter para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
        
    }
}