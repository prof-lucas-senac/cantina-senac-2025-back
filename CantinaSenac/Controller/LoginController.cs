class LoginController
{
    public static List<Aluno> alunos = new List<Aluno>();
<<<<<<< HEAD
=======

>>>>>>> master
    public bool Autenticar(string email, string senha)
    {
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Email == email && aluno.Senha == senha)
            {
                return true;
            }
        }
        return false;
    }
}