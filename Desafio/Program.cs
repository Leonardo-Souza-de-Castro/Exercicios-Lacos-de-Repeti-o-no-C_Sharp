using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = -1;
            int valor2 = 1;
            int valor3 = 0;

            do
            {
                valor3 = valor1 + valor2;
                valor1 = valor2;
                valor2 = valor3;
                
                Console.Write(valor3 + ", ");
            } while (valor3 <= 500);

        }
    }
}
