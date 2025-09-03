interface IDAO
{
    public abstract void Cadastrar(Aluno aluno);


    public abstract void Atualizar(Aluno aluno);

    public void Excluir(int id);
    public List<Aluno> ListarTodos();

    public Aluno Listar(int id);


}