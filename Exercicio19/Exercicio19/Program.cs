using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O Numero --{numero} é PAR");
            }
            else
            {
                Console.WriteLine($"Seu Numero {numero}, é IMPAR");
            }
        }
    }
}
