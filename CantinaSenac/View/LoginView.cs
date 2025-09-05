static class LoginView
{
    public static void Exibir()
    {
        string email;
        string senha;
        Console.WriteLine("bem vindo ao cantina senac");
        Console.WriteLine("login:");
        email = Console.ReadLine();
        Console.WriteLine("senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Aluno autenticado com sucesso! pressione enter para continuar");
            Console.ReadKey();
            Console.Clear();
            FeedbacksView.Exibir();
        }
        else
        {
            Console.WriteLine("Login ou senha incorretos. Pressione enter para tentar novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}