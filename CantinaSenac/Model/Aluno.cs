// Classe que representa um aluno no sistema, herdando da classe base abstrata Usuario
class Aluno : Usuario
{
    // Propriedade opcional que poderia associar o aluno a um curso específico
    // public Curso curso { get; set; }

    // Implementação do método abstrato para comentar em um feedback
    // Aqui você pode definir como o aluno interage com feedbacks existentes
    public override void ComentarFeedback()
    {
        // Exemplo futuro: adicionar comentário a um feedback
    }

    // Implementação do método abstrato para realizar login
    // Aqui você pode validar credenciais e definir regras específicas para alunos
    public override void Logar()
    {
        // Exemplo futuro: autenticar aluno com email e senha
    }

    // Implementação do método abstrato para publicar um feedback
    // Aqui você pode definir como o aluno cria e envia um novo feedback
    public override void PublicarFeedBack()
    {
        // Exemplo futuro: criar objeto Feedback e salvar no banco
    }
}
