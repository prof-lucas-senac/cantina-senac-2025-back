class FeedBackDAO : IDAO<FeedBack>
{
    private static List<FeedBack> feedBacks = new List<FeedBack>();

    public void Cadastrar(FeedBack objeto)
    {
        feedBacks.Add(objeto);
    }

    public void Atualizar(FeedBack objeto)
    {
        throw new NotImplementedException();
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public FeedBack Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<FeedBack> ListarTodos()
    {
        return feedBacks;
    }
}