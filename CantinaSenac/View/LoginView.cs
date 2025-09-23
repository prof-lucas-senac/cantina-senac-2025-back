static class LoginView
{
    public static void Exibir()
    {
<<<<<<< HEAD
        string email = "";
        string senha = "";

        System.Console.WriteLine("Bem-vind@ ao Cantina Senac!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");
        System.Console.WriteLine("Email:");
        email = Console.ReadLine()!;
        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine()!;

        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine("Aluno autenticado com sucesso! Pressione Enter para continuar.");
=======
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
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
<<<<<<< HEAD
            System.Console.WriteLine("Login e/ou Senha incorretos. Pressione Enter para tentar novamente.");
=======
            Console.WriteLine("Login falhou. Verifique suas credenciais. Pressione Enter para tentar novamente.");
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
<<<<<<< HEAD
=======
        
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
    }
}