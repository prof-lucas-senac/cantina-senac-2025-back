public static class LoginView
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("         TELA DE LOGIN             ");
        Console.WriteLine("===================================\n");

        Console.WriteLine("E-mail: ___________________________\n");
        string email = Console.ReadLine();

        Console.WriteLine("Senha:  ___________________________");
        string senha = Console.ReadLine();
        Console.WriteLine("===================================\n");


        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine("Aluno autenticado com sucesso! precione enter para continuar.");
            Console.ReadKey();
            FeedBacksView.Exibir();
        }
        else
        {
            System.Console.WriteLine("E-mail e/ou senha incorretos. Pressione Enter para tentar novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}


