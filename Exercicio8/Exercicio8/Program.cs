using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quando Dinheiro Possui na carteira");

            double money = double.Parse(Console.ReadLine());
            var dollar = 5.21;

            var price = money / dollar;

            Console.WriteLine($"Na conversão você Possui {price} dolares");

            //string[] numeros = Console.ReadLine().Split(' ');
            //Console.WriteLine("digite nomes");
            //string[] Linha = Console.ReadLine().Split(' ');

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine($"este é seu{numeros[i]}");
            //}
        }    
    }
}
