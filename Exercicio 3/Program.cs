using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            double salario = 0;
            string estado_civil = "";
            bool formulario = false;

            do
            {
                formulario = false;
                Console.WriteLine("Insira Seu Nome");
                nome = Console.ReadLine();

                Console.WriteLine("Insira Sua Idade");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira Seu Sálario");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira seu Estado Civil c(casado(a)) s(solteiro(s)) v(viuvo(a)) d(divorciado(a))");
                estado_civil = Console.ReadLine().ToLower();

                if (nome == "")
                {
                    Console.WriteLine("O nome não pode estar vazio \nPor Favor Digite Novamente!");
                    formulario = true;
                }
                if ((idade < 0) || (idade > 150))
                {
                    Console.WriteLine("Idade Invalida \nDigite Novamente");
                    formulario = true;
                }
                if (salario == 0)
                {
                    Console.WriteLine("Valor de Salario Invalido \nDigite Novamente");
                    formulario = true;
                }

                switch (estado_civil)
                {
                    case "c":
                        Console.WriteLine("Formulario preenchido com sucesso!!");
                        break;
                    case "s":
                        Console.WriteLine("Formulario preenchido com sucesso!!");
                        break;
                    case "v":
                        Console.WriteLine("Formulario preenchido com sucesso!!");
                        break;
                    case "d":
                        Console.WriteLine("Formulario preenchido com sucesso!!");
                        break;

                    default:
                        Console.WriteLine("Estado Civil Invalido Digite Novamente");
                        formulario = true;
                        break;
                }

            } while (formulario == true);
        }
    }
}
