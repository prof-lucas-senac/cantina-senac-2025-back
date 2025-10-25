class CadastroView
{
    public static void Exibir(Aluno aluno)
    {
        System.Console.WriteLine("Digite seu nome de usuario: ");
        aluno.NomeUsuario = Console.ReadLine();
        System.Console.WriteLine("Entre com o email: ");
        aluno.Email = Console.ReadLine();
        System.Console.WriteLine("Entre com a senha: ");
        aluno.Senha = Console.ReadLine();
        new AlunoController().AdicionarAluno(aluno);
    }
}
        