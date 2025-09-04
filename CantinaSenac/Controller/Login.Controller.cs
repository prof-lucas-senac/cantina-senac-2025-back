public class LoginController
{
    public bool Autenticar(string email, string senha)
    {
        return AlunoDAO.alunos.Exists(a => a.Email == email && a.Senha == senha);
    }
}
