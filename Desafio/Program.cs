using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 1;
            int valor3 = 0;

            do
            {
                valor3 = valor1 + valor2;
                Console.Write(valor3 + ", ");
                valor1 = valor2;
                valor2 = valor3;
            } while (valor2 <= 500);

        }
    }
}
