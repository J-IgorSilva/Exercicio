using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de medidas\n");
            float numero = float.Parse(Console.ReadLine());
            Console.WriteLine("A distancia em metros é "+ (numero/1000));
            Console.WriteLine("A distancia em centimetros é " + (numero * 1000));

        }
    }
}
