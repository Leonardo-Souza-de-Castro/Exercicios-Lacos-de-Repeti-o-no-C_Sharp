using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            do
            {
                Console.WriteLine("Insira um número de 1 á 10");
                numero = double.Parse(Console.ReadLine());

                if (numero > 10)
                {
                    Console.WriteLine("Número invalido Digite Novamente");
                }
                else
                {
                    Console.WriteLine("Numero Valido");
                    Console.WriteLine("FIM DA EXECUSÃO");
                }

            } while (numero > 10);
        }
    }
}
