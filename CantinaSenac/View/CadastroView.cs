class CadastroView
{

    public static void Exibir(Aluno aluno)
    {

        System.Console.WriteLine("Digite o seu email:");
        aluno.Email = Console.ReadLine();

        System.Console.WriteLine("Digite sua senha:");
        aluno.Senha = Console.ReadLine();

        new AlunoController().Adicionar(aluno);
      }
}