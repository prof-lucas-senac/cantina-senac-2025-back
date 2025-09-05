class AlunoControler
{
    public void Adicionar(Aluno aluno)
    {
        new AlunoDAO().Cadastrar(aluno);
        LoginView.Exibir();
        Console.Clear();
    }
}