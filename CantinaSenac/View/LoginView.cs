static class LoginView
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("=== Login ===");
        Console.Write("Usuário: ");
        string email = Console.ReadLine();
        Console.Write("Senha: ");
        string senha = Console.ReadLine();

        // // Aqui você pode adicionar a lógica de autenticação
        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("Login bem-sucedido!");
            Console.ReadKey();
            FeedbacksView.Exibir();
            // Redirecionar para a próxima tela ou funcionalidade
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Exibir(); // Chama novamente para tentar o login
        }
    }

    // private static bool Autenticar(string usuario, string senha)
    // {
    //     // Lógica de autenticação (exemplo simples)
    //     return usuario == "admin" && senha == "admin";
    // }
}