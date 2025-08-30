class CadastroView
{
    public static void Exibir(Aluno aluno)
    {
        System.Console.WriteLine("Entre com o email: ");
        aluno.Email = Console.ReadLine();
        System.Console.WriteLine("Entre com a senha: ");
        aluno.Senha = Console.ReadLine();
        new AlunoController().Adicionar(aluno);
        
    }
}