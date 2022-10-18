using System;

namespace Exercico16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a velocidade atual do carro?");
            int velocidade = int.Parse(Console.ReadLine());

            if (velocidade > 80)
            {
                Console.WriteLine($"Voçê excedeu a velocidade permitida, sua multa atual é {(velocidade-80)*5}");
            }
            else
            {
                Console.WriteLine("Você não possue multas ate o momento:");
            }
        }
    }
}
