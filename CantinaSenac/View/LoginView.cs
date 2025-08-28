static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";
        System.Console.WriteLine("Bem vind@ a Cantina Senac!");
        System.Console.WriteLine("Por favor, insira suas credenciais:");
        System.Console.WriteLine("Email:");
        email = Console.ReadLine();

        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {

            System.Console.WriteLine("Aluno Autenticado com sucesso! Pressione enter para continuar");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
        else
        {
            System.Console.WriteLine("Login e/ou senha incorretos.");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}
