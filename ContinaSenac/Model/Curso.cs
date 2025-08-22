using System.Data;

public class Curso
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateInicio { get; set; }
    public DateTime DateFinal { get; set; }
    public string Descricao { get; set; }
    public void ApresentarCurso(){}
}