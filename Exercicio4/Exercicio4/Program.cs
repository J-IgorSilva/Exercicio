using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Notas!\n");
            Console.WriteLine("Digite a Primeira Nota\n");
            float nota = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Segunda Nota\n");
            float nota2 = float.Parse(Console.ReadLine());

            float resultado = (nota + nota2)/2;

            Console.WriteLine("A Media entre "+ nota+" e "+nota2+" e igual a "+ resultado);
        }
    }
}
