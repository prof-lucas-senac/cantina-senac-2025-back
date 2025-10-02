interface IDAO<T>
{
    public void Cadastrar(T entidade);
    public void Atualizar(T entidade);
    public void Excluir(T objeto);
    public List<T> ListarTodos();
    public T ListarPorId(int id);

 }