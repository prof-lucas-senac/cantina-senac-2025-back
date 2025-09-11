public class Comentario : Postagem
{

    public override string ToString()
    {
        return $"{usuario}: {Descricao}";
    }

}