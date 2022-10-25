using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descrubra se o ano é bissexto, Digite um ano: ");

            int ano = int.Parse(Console.ReadLine());

            if ((ano % 400 ==0)&&(ano%100!=0))
            {
                Console.WriteLine($"{ano} é um ano BISSEXTO");
            }
            else
            {
                Console.WriteLine("Esse ano não é BISSEXTO");
                
            }
        }
    }
}
