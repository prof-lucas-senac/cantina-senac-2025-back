public interface IDAO<T>
{
  void Cadastrar(T objeto);
  void Atualizar(T objeto);
  void Excluir(T objeto);

  T Listar(int id);

  List<T> ListarTodos();
}
