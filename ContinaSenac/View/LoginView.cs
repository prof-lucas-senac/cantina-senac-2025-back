static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";
        Console.WriteLine("Seja Bem-Vind@ à Cantina Senac!");
        Console.WriteLine("Por favor, preencha os campos abaixo:");
        Console.WriteLine("Email:");
        email = Console.ReadLine();
        Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Aluno autenticado com sucesso!");
            Console.ReadKey();
            FeedbackView.Exibir();
        }
        else
        {
            Console.WriteLine("Login e/ou senha incorretos.");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}