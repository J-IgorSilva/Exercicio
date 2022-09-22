using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Antecessor e Sucessor\n");
            Console.WriteLine("Digite um Numero\n");
            int numero;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O antecessor de "+ (numero-1)+ " e o sucesso e "+(numero+1));

        }
        
    }
}
