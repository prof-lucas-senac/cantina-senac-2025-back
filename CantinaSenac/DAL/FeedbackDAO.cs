using Microsoft.EntityFrameworkCore;

// Classe responsável por acessar os dados da entidade Feedback no banco de dados
class FeedbackDAO : IDAO<Feedback>
{
    private CantinaSenacContext contexto = new CantinaSenacContext();

    public void Atualizar(Feedback objeto)
    {
        var feedbackExistente = contexto.Feedbacks.Find(objeto.Id);
        if (feedbackExistente != null)
        {
            feedbackExistente.Descricao = objeto.Descricao;
            feedbackExistente.DataPublicacao = objeto.DataPublicacao;

            contexto.SaveChanges();
        }
    }


    public void Cadastrar(Feedback objeto)
    {
        contexto.Entry(objeto.Usuario).State = EntityState.Unchanged;
        contexto.Feedbacks.Add(objeto);
        contexto.SaveChanges();
    }

    public void Excluir(Feedback objeto)
    {
        contexto.Feedbacks.Remove(objeto);
        contexto.SaveChanges();
    }

    public void Excluir(int id)
    {
        var feedback = contexto.Feedbacks.Find(id);
        if (feedback != null)
        {
            contexto.Feedbacks.Remove(feedback);
            contexto.SaveChanges();
        }
    }

    public Feedback ListarPorId(int id)
    {
        Feedback? feedback = null;
        feedback = contexto.Feedbacks.FirstOrDefault(
            feedback => feedback.Id == id
        );
        return feedback;
    }

    public List<Feedback> ListarTodos()
    {
        return contexto.Feedbacks.Include(f => f.Usuario).ToList();
    }
}
