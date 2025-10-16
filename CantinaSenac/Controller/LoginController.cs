// Classe responsável por controlar o processo de autenticação de alunos no sistema
class LoginController
{
    public bool Autenticar(string email, string senha)
    {
        List<Aluno> alunos = new AlunoDAO().ListarTodos();
        
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Email == email && aluno.Senha == senha)
            {
                // Se encontrar, retorna o aluno autenticado
                return aluno;
            }
        }

        // Se não encontrar nenhum aluno com as credenciais fornecidas, retorna null
        return null;
    }
}
