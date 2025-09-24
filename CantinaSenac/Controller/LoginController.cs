class LoginController
{

    public bool Autenticar(string email, string senha)
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();
        
    public static List<Aluno> alunos = new List<Aluno>();

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
