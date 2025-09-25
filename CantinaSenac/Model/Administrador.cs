// Classe que representa um administrador do sistema, herdando funcionalidades da classe base Usuario
class Adminstrador : Usuario
{
    // Método para suspender um usuário ou recurso (a ser implementado)
    public void Suspender()
    {
        // Ex: alterar status de um usuário para "suspenso"
    }

    // Método para deletar um usuário ou recurso (a ser implementado)
    public void Deletar()
    {
        // Ex: remover um usuário ou conteúdo do sistema
    }

    // Método para listar todos os usuários ou registros relevantes (a ser implementado)
    public void ListarTodos()
    {
        // Ex: retornar todos os usuários, cursos ou feedbacks
    }

    // Método para recuperar o histórico de ações ou registros (a ser implementado)
    public void RecuperarHistorico()
    {
        // Ex: acessar logs ou histórico de atividades de um usuário
    }

    // Método para cadastrar um novo curso no sistema (a ser implementado)
    public void CadastrarCurso()
    {
        // Ex: adicionar curso com nome, descrição e carga horária
    }

    // Método para atualizar informações de um curso existente (a ser implementado)
    public void AtualizarCurso()
    {
        // Ex: editar dados de um curso já cadastrado
    }

    // Método para deletar um curso do sistema (a ser implementado)
    public void DeletarCurso()
    {
        // Ex: remover curso da base de dados
    }

    // Sobrescreve o método de publicação de feedback da classe Usuario
    public override void PublicarFeedBack()
    {
        // Ex: permitir que o administrador publique feedbacks institucionais
    }

    // Sobrescreve o método de comentário em feedback da classe Usuario
    public override void ComentarFeedback()
    {
        // Ex: permitir que o administrador comente em feedbacks de alunos
    }

    // Sobrescreve o método de login da classe Usuario
    public override void Logar()
    {
        // Ex: autenticar administrador com permissões elevadas
    }
}
