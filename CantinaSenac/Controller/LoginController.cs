using System.Reflection.Metadata;

class LoginController
{



    public bool Autenticar(string email, string senha)
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();

        foreach (Aluno autentica in alunos)
        {
            if (autentica.Email == email && autentica.Senha == senha)
            {
                System.Console.WriteLine("Aluno autenticado com sucesso!");
                return true;
            }
        }


        // foreach (Aluno aluno in alunos)
        // {
        //     if (aluno.Email == email && aluno.Senha == senha)
        //     {
        //         return true;
        //     }
        // }
        
        return false;

    }

}