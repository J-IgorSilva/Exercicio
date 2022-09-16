using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para somar digite dois numeros\n");
            Console.WriteLine("Digite primeiro numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            var resultado = numero + numero2;

            Console.WriteLine(" a soma entre " + numero + " e " +numero2+" e igual a "+ resultado);


        }
    }
}
