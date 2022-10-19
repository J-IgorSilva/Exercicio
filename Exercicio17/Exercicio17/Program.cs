using System;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano voçê nasceu ?");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            var idadeAtual = 2022-anoDeNascimento;

            if (idadeAtual < 18)
            {
                Console.WriteLine($"Voçê possue atualmente {idadeAtual}Anos, seu voto não é obrigatorio:");
            }
            else
            {
                Console.WriteLine($"Você Possue {idadeAtual}Anos, Seu voto é obrigatorio.");
            }
            
        }
    }
}
