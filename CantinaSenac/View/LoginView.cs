// Classe estática responsável por exibir a interface de login no console
public static class LoginView
{
    // Método principal que exibe a tela de login e realiza a autenticação do aluno
    public static void Exibir()
    {
        Console.Clear(); // Limpa a tela do console

        // Exibe o cabeçalho da tela de login
        Console.WriteLine("===================================");
        Console.WriteLine("         TELA DE LOGIN             ");
        Console.WriteLine("===================================\n");

        // Solicita o e-mail do usuário
        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        // Solicita a senha do usuário
        Console.Write("Senha: ");
        string senha = Console.ReadLine();
        Console.WriteLine("===================================\n");

        // Chama o controller para autenticar o aluno com base nas credenciais fornecidas
        Aluno aluno = new LoginController().Autenticar(email, senha);

        // Se o aluno for encontrado, exibe mensagem de sucesso e redireciona para a tela de feedbacks
        if (aluno != null)
        {
            Console.WriteLine("Aluno autenticado com sucesso! Pressione Enter para continuar.");
            Console.ReadKey();
            FeedBacksView.Exibir(aluno); // Passa o aluno autenticado para a próxima view
        }
        else
        {
            // Se as credenciais forem inválidas, exibe mensagem de erro e reinicia a tela de login
            Console.WriteLine("E-mail e/ou senha incorretos. Pressione Enter para tentar novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir(); // Recursivamente exibe a tela de login novamente
        }
    }
}
