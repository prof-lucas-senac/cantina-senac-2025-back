interface IDAO <T>
{
    public abstract void Cadastrar(T objeto);


    public abstract void Atualizar(T objeto);

    public void Excluir(T objeto);
    public List<T> ListarTodos();

    public T ListarPorId(int id);


}