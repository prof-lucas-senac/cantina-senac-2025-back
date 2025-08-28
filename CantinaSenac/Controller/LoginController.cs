class LoginController
{
    public static List<Aluno> alunos = new List<Aluno>();

    public bool Autenticar(string email, string senha)
    {
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Email == email && aluno.Email == senha)
            {
                return true;
            }

        }
        return false;
    } 

}