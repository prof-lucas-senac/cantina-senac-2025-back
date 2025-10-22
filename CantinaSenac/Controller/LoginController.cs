class LoginController
{
<<<<<<< HEAD
    

    public bool Autenticar(string email, string senha)
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();

=======
    public bool Autenticar(string email, string senha)
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();
        
>>>>>>> master
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