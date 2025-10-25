static class AdminView
{
    public static void Exibir()
    {
        System.Console.WriteLine("Bem-vind@ ao Painel Administrativo!\n");
        System.Console.WriteLine("Selecione uma opção:");
        System.Console.WriteLine("1. Gerenciar Alunos");
        System.Console.WriteLine("2. Sair");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                AlunosView.Exibir();
                break;
            case "2":
                System.Console.WriteLine("Saindo...");
                break;
            default:
                System.Console.WriteLine("Opção inválida. Tente novamente.");
                Exibir();
                break;
        }
    }
}