class LoginController
{
    public static List<Aluno> alunos = new List<Aluno>();

    public bool Autenticar(string email, string senha)
    {
<<<<<<< HEAD
        foreach (Usuario aluno in alunos)
=======
        foreach (Aluno aluno in alunos)
>>>>>>> master
        {
            if (aluno.Email == email && aluno.Senha == senha)
            {
                return true;
            }
<<<<<<< HEAD

=======
>>>>>>> master
        }
        return false;
    }
}