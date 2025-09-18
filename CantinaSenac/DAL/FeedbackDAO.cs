class FeedBackDAO : IDAO<FeedBack>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();

    public void Cadastrar(FeedBack objeto)
    {
        contexto.FeedBacks.Add(objeto);
        contexto.SaveChanges();
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
        return contexto.FeedBacks.ToList();
    }
}