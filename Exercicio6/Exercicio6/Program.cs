using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero\n");
            float numero = float.Parse(Console.ReadLine());
            Console.WriteLine("O dobro desse numero é "+(numero*2)+" e sua terça parte é "+(numero/3));
        }
    }
}
