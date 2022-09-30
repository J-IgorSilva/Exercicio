using System;

namespace Exercicio10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores para calcular o valor de Delta!");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int delta ,x ;

            delta =(b * b )- 4*a*c;

            x = (int)(-b + (Math.Sqrt(b) - 4 * a * c) / 2*a);

            Console.WriteLine(x);

        }
    }
}
