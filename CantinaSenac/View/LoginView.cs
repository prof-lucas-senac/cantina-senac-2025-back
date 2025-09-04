static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";

        System.Console.WriteLine("Bem vindo(a) à Cantina Senac!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");

        System.Console.WriteLine("Email:");
        email = Console.ReadLine();

        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine("Aluno autenticado com sucesso! Pressione Enter para continuar.");
            Console.ReadKey();
            FeedbackView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Ocorreu um erro :( Pressione Enter para tentar novamente!");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}