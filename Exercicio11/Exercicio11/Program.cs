using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual preço do produto?");
            var produto = int.Parse(Console.ReadLine());
            var desconto = (produto * 5) / 100;

            Console.WriteLine($"O produto custa { produto}, Com desconto o preço final é {produto-desconto}");
        }
    }
}
