using System;

namespace Exercicio18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            var aluno = Console.ReadLine();
            double media, nota1, nota2;
            Console.WriteLine("Qual a primeira nota do aluno? ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Segunda Nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = nota1 + nota2 / 2;

            if (media < 7)
            {
                Console.WriteLine($"A media final do aluno {aluno} é: {media}, REPROVADO");
            }
            else
            {
                Console.WriteLine($"A media do aluno {aluno} é: {media}, APROVADO");
            }

           
        }
    }
}
