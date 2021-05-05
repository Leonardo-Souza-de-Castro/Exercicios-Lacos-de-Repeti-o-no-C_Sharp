using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "";
            string email = "";

            do
            {
                Console.WriteLine("Insira seu Nome de Usuario");
                email = Console.ReadLine().ToLower();
                Console.WriteLine("Insira sua Senha");
                senha = Console.ReadLine().ToLower();

                if (senha == "")
                {
                    senha = email;
                }

                if (senha == email)
                {
                    Console.WriteLine("Senha inválida");
                }
                else
                {
                    Console.WriteLine("Logado com sucesso!!");
                }

            } while (senha == email);
        }
    }
}
