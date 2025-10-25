
 public abstract class Usuario
{
    public int Id { get; set; }
    public string NomeUsuario { get; set; } = string.Empty;
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Status { get; set; }
    public string? Foto { get; set; }
    public List<Postagem> Postagens { get; set; } = new();

}