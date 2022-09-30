using System;

namespace Exercicio9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto de largura a tera a area pintada?");

            double heigth = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto de altura tem sua parede?");

            double width = double.Parse(Console.ReadLine());

            var area = width * heigth;
            var painting = (width * heigth) *2;

            Console.WriteLine($"Voce Gastara {painting} litro de tinto para pintar uma parede de {area} metros");
        }
    }
}
