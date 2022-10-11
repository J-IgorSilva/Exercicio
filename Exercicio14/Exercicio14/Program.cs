using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dias o funcionario trabalhou esse mes?");
            int diasTrabalhado = int.Parse(Console.ReadLine());
            var hora = 25;

            Console.WriteLine($"valor a ser pago para o funcionario é de :{(diasTrabalhado*8)*hora}");


        }
    }
}
