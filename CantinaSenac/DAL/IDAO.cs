interface IDAO
{
    public void Cadastrar(Aluno aluno);
    public void Atualizar();
    public void Excluir();
    public List<Aluno> ListarTodos();
    public Aluno Listar(int Id); 
}