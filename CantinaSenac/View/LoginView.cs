static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";
        System.Console.WriteLine("Bem-vind@ a Cantina Senac!\n");
        System.Console.WriteLine("Insira as informações da sua conta:\n ");

        System.Console.WriteLine("Email:");
        email = Console.ReadLine();
        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine("Aluno logado com sucesso! Pressione Enter para continuar");
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Login e/ou senha incorretos. Pressione Enter para tentar novamente!");
        }
    }
}