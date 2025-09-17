

class FeedbackDAO : IDAO<Feedback>
{
    private static List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    
        
        public void Cadastrar(Feedback objeto)
        {
            Feedbacks.Add(objeto);
        }
        public void Atualizar(Feedback objeto)
        {
            throw new NotImplementedException();
        }

    public void Cadastrar(Feedback objeto)
    {
        Feedbacks.Add(objeto);
    }

        public Feedback Listar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feedback> ListarTodos()
        {
            return Feedbacks;
        }  


    
       


}