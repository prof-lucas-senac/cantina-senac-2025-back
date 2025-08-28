
using CantinaSenac.View;

class LoginController
{
    public static List<Aluno> alunos = new List<Aluno>();

    public bool Autenticar(string login, string senha)
    {
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Email == login && aluno.Senha == senha)
            {
                return true;
            }
        }
        return false;
    }
}