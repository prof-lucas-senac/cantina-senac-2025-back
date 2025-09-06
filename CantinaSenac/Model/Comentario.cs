public class Comentario : Postagem
{
    public Comentario(string descricao, Usuario usuarioComentando) : base(descricao, usuarioComentando)
    {
    }

    public override string ToString()
    {
        return $"{usuario}: {Descricao}";
    }

}