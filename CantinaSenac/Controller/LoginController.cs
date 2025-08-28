class LoginController
{
    public static List<Aluno> alunos = new List<Aluno>();

    public bool Autenticar(string email, string senha)
    {
        foreach (Usuario aluno in alunos)
        {
            if (aluno.Email == email && aluno.Senha == senha)
            {
                return true;
            }

        }
        return false;
    }
}