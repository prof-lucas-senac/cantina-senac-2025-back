// Interface genérica que define operações básicas de acesso a dados (DAO - Data Access Object)
// Pode ser implementada por qualquer classe que manipule entidades do tipo T
interface IDAO<T>
{
    // Cadastra um novo objeto do tipo T no banco de dados
    public void Cadastrar(T objeto);

    // Atualiza os dados de um objeto existente do tipo T
    public void Atualizar(T objeto);

    // Exclui um objeto do banco com base no seu identificador
    public void Excluir(T id);

    // Retorna uma lista com todos os objetos do tipo T cadastrados
    public List<T> ListarTodos();

    // Retorna um único objeto do tipo T com base no seu identificador
    public T ListarPorId(int id);
}
