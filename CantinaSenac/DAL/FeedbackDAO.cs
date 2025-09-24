class FeedBackDAO : IDAO<FeedBack>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();

    public void Cadastrar(FeedBack objeto)
    {
        contexto.FeedBacks.Add(objeto);
        contexto.SaveChanges(); // salva as alterações no banco de dados
    }

    public void Atualizar(FeedBack objeto)
    {
       contexto.FeedBacks.Update(objeto);
       contexto.SaveChanges();
    }

    public void Excluir(FeedBack objeto)
    {
        contexto.FeedBacks.Remove(objeto);
        contexto.SaveChanges();
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