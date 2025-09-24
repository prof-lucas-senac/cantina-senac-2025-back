interface IDAO <T>
{

  public void Cadastrar(T objeto);
  public abstract void Atualizar(T objeto);

  public abstract string Excluir(T id);

  public List<T> ListarTodos();

  public T Listar(int Id);
}