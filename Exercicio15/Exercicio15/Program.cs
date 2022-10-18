using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //hora 1440 minutos
            //ano 8760 horas
            // dia possue 34560 minutos

            Console.WriteLine("Quantos Cigarros voçê fuma por dia?");
            int cigarros = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos anos voçê ja fumou?");
            int anos = int.Parse(Console.ReadLine());

            var dias = (anos * 365);

            var tempoPerdido = (dias * 34560) / (cigarros * 10);
            Console.WriteLine($"Durante {anos}Anos, fumando voçê ja perdeu {tempoPerdido} minutos");

        }
    }
}
