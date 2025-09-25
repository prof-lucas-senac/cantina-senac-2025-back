// Classe que representa um curso disponível no sistema
public class Curso
{
    // Identificador único do curso
    public int Id { get; set; }

    // Nome do curso (ex: "Programação Web", "Gestão de Projetos")
    public string Nome { get; set; }

    // Data de início do curso
    public DateTime DataInicio { get; set; }

    // Data de término do curso
    public DateTime DataFinal { get; set; }

    // Descrição detalhada do conteúdo ou objetivo do curso
    public string Descricao { get; set; }

    // Método que poderá ser usado para exibir as informações do curso
    public void ApresentarCurso()
    {
        // Exemplo de implementação futura:
        // Console.WriteLine($"Curso: {Nome} - {Descricao}");
    }
}
