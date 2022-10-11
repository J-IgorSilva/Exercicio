using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto KM foram percorridos pelo carro alugado");
            var kmRodados = int.Parse(Console.ReadLine());
            var custoPorKm = kmRodados*0.20;
            Console.WriteLine("Quantos dias o carro foi alugado?");
            int aluguel = int.Parse(Console.ReadLine());
            int precoAluguel = aluguel * 90;

            Console.WriteLine($"O valor total a pagar por aluguel do carro é:");
            Console.WriteLine($"Valor rodado {custoPorKm}");
            Console.WriteLine($"Valor por dias alugado {precoAluguel}");



        }
    }
}
