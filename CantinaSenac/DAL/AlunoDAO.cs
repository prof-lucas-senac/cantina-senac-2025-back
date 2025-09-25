// Classe responsável por realizar operações de acesso a dados da entidade Aluno
// Implementa a interface genérica IDAO<Aluno> para garantir consistência com outras DAOs
class AlunoDAO : IDAO<Aluno>
{
    // Instancia o contexto do Entity Framework para interagir com o banco de dados
    private CantinaSenacContext contexto = new CantinaSenacContext();

    // Método para atualizar os dados de um aluno existente (ainda não implementado)
    public void Atualizar(Aluno aluno)
    {
        throw new NotImplementedException(); // será usado para editar dados de um aluno
    }

    // Método para cadastrar um novo aluno no banco de dados
    public void Cadastrar(Aluno aluno)
    {
        // ⚠️ Comentado: aqui deveria adicionar o aluno ao contexto e salvar as alterações
        // Exemplo de implementação:
        // contexto.Alunos.Add(aluno);
        // contexto.SaveChanges();
    }

    // Método para excluir um aluno do banco (ainda não implementado)
    public void Excluir(Aluno objeto)
    {
        throw new NotImplementedException(); // será usado para remover um aluno específico
    }

    // Método para buscar um aluno pelo ID (ainda não implementado)
    public Aluno Listar(int Id)
    {
        throw new NotImplementedException(); // será usado para retornar um aluno específico
    }

    // Método para listar todos os alunos cadastrados no banco
    public List<Aluno> ListarTodos() 
    {
        return contexto.Alunos.ToList(); // retorna todos os registros da tabela Alunos
    }
}
