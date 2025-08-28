public static class LoginView
{
    public static void Exibir()
    {
        string? email = "";
        string? senha = "";
        Console.WriteLine("¬¬¬¬¬ |Seja Bem Vind@ à Cantina Senac| ¬¬¬¬¬\n");
        Console.WriteLine("Digite seus dados abaixo:\n");

        Console.Write("Email: ");
        email = Console.ReadLine();
        Console.Write("Senha: ");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Login efetuado com sucesso! Pressione Enter para continuar!");
            Console.ReadKey();
            FeedbacksView.Exibir();
        }
        else
        {
            Console.WriteLine("Email e/ou senha incorreto! Pressione Enter para tentar novamente!");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}