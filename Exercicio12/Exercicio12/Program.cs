using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o valor do salario");
            double funcionarioSalario = double.Parse(Console.ReadLine());
            var aumentoSalario = (funcionarioSalario * 15) / 100;

            Console.WriteLine($"O valor do salario do funcionario é de {funcionarioSalario}\n");
            Console.WriteLine($"Com o aumento vigente passara a ser de {aumentoSalario+funcionarioSalario}");

        }
    }
}
