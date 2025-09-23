class LoginController
{
<<<<<<< HEAD
    public bool Autenticar(string email, string senha)
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();
        
=======
    public static List<Aluno> alunos = new List<Aluno>();

    public bool Autenticar(string email, string senha)
    {
>>>>>>> 57cd655051b3bef58785277520da2acb380a3564
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