interface IDAO<T>
{
    public void Cadastrar(T entidade);
    public void Atualizar(T entidade);
    public void Excluir(int id);
    public List<T> ListarTodos();
    public T listar(int id);

 }