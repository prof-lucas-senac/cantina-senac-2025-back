// Classe responsável por controlar o processo de autenticação de alunos no sistema
class LoginController
{
    // Método que verifica se existe um aluno com o email e senha fornecidos
    // Retorna o objeto Aluno se as credenciais forem válidas, ou null se não encontrar
    public Aluno Autenticar(string email, string senha)
    {
        // Obtém a lista de todos os alunos cadastrados no banco
        List<Aluno> alunos = new AlunoDAO().ListarTodos();

        // Percorre a lista de alunos para verificar se há correspondência de email e senha
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
