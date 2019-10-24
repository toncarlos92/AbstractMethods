using System;
using ExercicioProposto_MetodosAbstratos.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioProposto_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, rendaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, rendaAnual, funcionarios));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.Nome + ": $ " + pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                sum += pessoa.Imposto();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
