public class Feedback : Postagem
{
    public string Texto { get; set; }
    public DateTime Data { get; set; }
    public Feedback(string texto)
    {
        Texto = texto;
        Data = DateTime.Now;
    }
}