
public static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";
        Console.WriteLine("Bem vindes à Cantina Senac!!!");
        Console.WriteLine("Digite seu email: ");
        email = Console.ReadLine()!;
        Console.WriteLine("Digite sua senha:");
        senha = Console.ReadLine()!;
        Console.WriteLine("Login concluido com sucesso");

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Aluno autenticado com sucesso!!!");

        }
        else
        { 
            Console.WriteLine("Login ou Senha incorretos.");
        }
    }
}
