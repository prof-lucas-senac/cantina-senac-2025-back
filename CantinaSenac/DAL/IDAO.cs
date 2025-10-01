public interface IDAO<T>
{
    public void Cadastrar(T objeto);
    public void Atualizar(T objeto);
    public void Excluir(T objeto);
    public void Remover(int id);

    T Listar(int id);
    List<T> ListarTodos();
}
