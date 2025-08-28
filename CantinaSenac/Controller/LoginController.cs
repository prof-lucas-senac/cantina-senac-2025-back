class LoginController
{
    static public List<Aluno> alunos = new List<Aluno>();
    public bool Auntenticar(string email, string senha)
    {
        Aluno alunoAutenticado = alunos.Find(a => a.Email == email && a.Senha == senha);
        if (alunoAutenticado == null)
        {
            return false;
        }
        return true;
    }
}