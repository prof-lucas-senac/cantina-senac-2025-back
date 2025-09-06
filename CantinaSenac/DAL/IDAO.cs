interface IDAO <T>
{
    public void Cadastrar(T aluno);
    public void Atualizar(T aluno);
    public void Excluir(int id);
    public List<T> ListarTodos();

    public T Listar(int id);
}