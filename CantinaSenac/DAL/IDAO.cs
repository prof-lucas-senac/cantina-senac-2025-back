public interface IDAO <T>
{
    public void Cadastrar(T objeto);
    public void Atualizar(T objeto);
    public void Excluir(T id);
    public List<T> ListarTodos();
    public T ListarPorId(int id);
}
