interface IDAO
{
    public void Cadastrar(Aluno aluno);
    public void Atualizar(Aluno aluno);
    public void Excluir(int id);
    public List<Aluno> ListarTodos();
    public Aluno listar(int id);

 }