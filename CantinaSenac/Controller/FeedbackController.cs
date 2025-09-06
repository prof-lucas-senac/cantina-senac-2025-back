    public static class FeedbackController
    {
         private static List<Feedback> _feedbacks = new List<Feedback>();

        public static void Salvar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("\nNada foi informado. Feedback não salvo.");
                return;
            }

            var novo = new Feedback(texto)
            {
                Id = _feedbacks.Count + 1 
            };

            _feedbacks.Add(novo);
            Console.WriteLine("\nFeedback salvo com sucesso!");
        }
        public static List<Feedback> Listar()
        {
            return _feedbacks;
        }
    }
