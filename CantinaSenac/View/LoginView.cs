public static class LoginView
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("         TELA DE LOGIN             ");
        Console.WriteLine("===================================\n");

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.Write("Senha: ");
        string senha = Console.ReadLine();
        Console.WriteLine("===================================\n");

        Aluno aluno = new LoginController().Autenticar(email, senha);
        if (aluno != null)
        {
            Console.WriteLine("Aluno autenticado com sucesso! Pressione Enter para continuar.");
            Console.ReadKey();
            FeedBacksView.Exibir(aluno); // Agora passa o aluno autenticado
        }
        else
        {
            Console.WriteLine("E-mail e/ou senha incorretos. Pressione Enter para tentar novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}
