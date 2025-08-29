<<<<<<< HEAD

=======
>>>>>>> master
static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";

<<<<<<< HEAD
        System.Console.WriteLine("Bem vindo(a) à Cantina Senac!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");

        System.Console.WriteLine("Email:");
        email = Console.ReadLine();

=======
        System.Console.WriteLine("Bem-vind@ ao Cantina Senac!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");
        System.Console.WriteLine("Email:");
        email = Console.ReadLine();
>>>>>>> master
        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            System.Console.WriteLine("Aluno autenticado com sucesso! Pressione Enter para continuar.");
            Console.ReadKey();
<<<<<<< HEAD
            FeedbeckView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Ocorreu um erro :( Pressione Enter para tentar novamente!");
=======
            FeedbacksView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Login e/ou Senha incorretos. Pressione Enter para tentar novamente.");
>>>>>>> master
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
<<<<<<< HEAD

=======
>>>>>>> master
}