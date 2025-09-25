// Classe responsável por controlar as operações relacionadas à entidade Aluno
// Atua como intermediária entre a camada de apresentação (views) e a camada de dados (DAO)
class AlunoController
{
    // Método que recebe um objeto Aluno e o envia para ser cadastrado no banco de dados
    public void Adicionar(Aluno aluno)
    {
        // Cria uma instância de AlunoDAO e chama o método Cadastrar para salvar o aluno
        new AlunoDAO().Cadastrar(aluno);
    }
}
