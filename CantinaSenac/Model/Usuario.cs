// Classe abstrata que representa um usuário genérico do sistema
// Serve como base para outras classes como Aluno, Administrador, etc.
abstract class Usuario
{
    // Identificador único do usuário
    public int Id { get; set; }

    // Nome de exibição do usuário
    public string NomeDoUsuario { get; set; }

    // Endereço de e-mail do usuário
    public string Email { get; set; }

    // Senha de acesso do usuário
    public string Senha { get; set; }

    // Status do usuário (ex: ativo, suspenso, etc.)
    public int Status { get; set; }

    // Caminho ou URL da foto de perfil do usuário (opcional)
    public string? Foto { get; set; }

    // Lista de postagens feitas pelo usuário
    public List<Postagem> Postagens { get; set; }

    // Método abstrato para publicar um feedback
    // Deve ser implementado pelas classes derivadas
    public abstract void PublicarFeedBack();

    // Método abstrato para comentar em um feedback
    // Deve ser implementado pelas classes derivadas
    public abstract void ComentarFeedback();

    // Método abstrato para realizar login
    // Deve ser implementado pelas classes derivadas
    public abstract void Logar();
}
