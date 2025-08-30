using System.ComponentModel;

public class AlunoController
{
    public void AdicionarAluno()
    {
        Aluno aluno = new Aluno();
        
        Console.WriteLine("insira o email do aluno:");
        aluno.Email = Console.ReadLine();
        Console.WriteLine("insira a senha do aluno:");
        aluno.Senha = Console.ReadLine();
        
        new AlunoDAO().Cadastrar(aluno);
    }
}