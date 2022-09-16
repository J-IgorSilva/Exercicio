using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do funcionario!");
            var nome = Console.ReadLine();
            var salario = double.Parse(Console.ReadLine());
            Console.WriteLine("O funcionario " + nome + " tem um salario de " + salario + " em Junho");

        }
    }
}
