class Administrador : Usuario
{


    public void Suspender(){}
    public void Deletar(){}
    public void ListarTodos(){}
    public void RecuperarHistórico(){}
    public void CadastrarCurso(){}
    public void AtualizarCurso(){}
    public void DeletarCurso(){}

    public override void Cadastrar()
    {
        throw new NotImplementedException();
    }

    public override void Atualizar()
    {
        throw new NotImplementedException();
    }

    public override void PublicarFeedBack()
    {
        throw new NotImplementedException();
    }

    public override void ComentarFeedBack()
    {
        throw new NotImplementedException();
    }

    public override void Logar()
    {
        throw new NotImplementedException();
    }
}