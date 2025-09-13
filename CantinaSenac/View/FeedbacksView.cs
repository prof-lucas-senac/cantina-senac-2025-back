   public static class FeedbacksView
    {
       
        public static void Exibir()
        {
            int opcao = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU DE FEEDBACKS =====");
                Console.WriteLine("1 - Cadastrar novo feedback");
                Console.WriteLine("2 - Listar feedbacks cadastrados");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
 
                int.TryParse(Console.ReadLine(), out opcao);
 
                switch (opcao)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 0:
                        Console.WriteLine("Voltando ao menu anterior...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
 
                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                }
 
            } while (opcao != 0);
        }
       
        private static void Cadastrar()
    {
        Console.Clear();
        Console.WriteLine("===== CADASTRAR FEEDBACK =====");
        Console.Write("Descreva seu feedback: ");
        var texto = Console.ReadLine();
        FeedbackController.Salvar(texto);
    }
 
        private static void Listar()
        {
            Console.Clear();
            Console.WriteLine("===== LISTA DE FEEDBACKS =====\n");
 
            var lista = FeedbackController.Listar();
 
            if (lista == null || lista.Count == 0)
            {
                Console.WriteLine("Nenhum feedback cadastrado ainda.");
                return;
            }
 
            foreach (var fb in lista)
            {
                Console.WriteLine($"{fb.Descricao}");
            }
        }
    }