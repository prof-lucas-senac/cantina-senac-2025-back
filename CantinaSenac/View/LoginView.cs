using System;

public static class LoginView
{
    public static void Exibir()
    {
        string email = "";
        string senha = "";

        Console.WriteLine("Bem-vind@ à Cantina Senac!");
        Console.WriteLine("Por favor, insira suas credenciais:");
        Console.Write("Email: ");
        email = Console.ReadLine();

        Console.Write("Senha: ");
        senha = Console.ReadLine();

        if (new LoginController().Autenticar(email, senha))
        {
            Console.WriteLine("\nAluno autenticado com sucesso! Pressione Enter para visualizar os feedbacks...");
            Console.ReadKey();
            Console.Clear();



        }
     
        else
            {
                Console.WriteLine("\nLogin e/ou senha incorretos.");
                Console.ReadKey();
                Console.Clear();


            }
        }

    }

