// Classe responsável por acessar os dados da entidade Feedback no banco de dados
class FeedbackDAO : IDAO<Feedback>
{
    // Instancia o contexto do Entity Framework para interagir com o banco
    private CantinaSenacContext contexto = new CantinaSenacContext();

    // Método para atualizar um feedback existente (ainda não implementado)
    public void Atualizar(Feedback objeto)
    {
        contexto.Feedbacks.Add(objeto);
        contexto.SaveChanges(); // será usado para editar um feedback já cadastrado
    }

    // Método para cadastrar um novo feedback no banco
    public void Cadastrar(Feedback objeto)
    {
        contexto.Feedbacks.Add(objeto);     // adiciona o feedback à tabela
        contexto.SaveChanges();             // salva as alterações no banco
    }

    // Método para excluir um feedback pelo ID (ainda não implementado)
    public void Excluir(Feedback objeto)
    {
        contexto.Feedbacks.Remove(objeto);
        contexto.SaveChanges(); // será usado para remover um feedback específico
    }

    // Método para buscar um feedback específico pelo ID (ainda não implementado)
    public Feedback Listar(int id)
    {
        throw new NotImplementedException(); // será usado para retornar um feedback individual
    }

    // Método para listar todos os feedbacks cadastrados
    public List<Feedback> ListarTodos()
    {
        return contexto.Feedbacks.ToList(); // retorna todos os registros da tabela Feedbacks
    }
}
