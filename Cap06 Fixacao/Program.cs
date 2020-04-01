using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cap06_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<FolhaPagamento> N = new List<FolhaPagamento>();


            Console.Write("Digite a quantidade de colaboradores:");
            int Colaborador = int.Parse(Console.ReadLine());

            for (int i = 0; i < Colaborador; i++)
            {
                Console.Write("Informe a id do colaborador: ");
                int Matricula = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do colaborador: ");
                string Nome = Console.ReadLine();
                Console.Write("Informe o Salario do colaborador: ");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                N.Add(new FolhaPagamento(Matricula, Nome, Salario));


            }

            Console.Write("Informe a Id do colaborador: ");
            int Matricula1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            FolhaPagamento emp1 = N.Find(x => x.Id == Matricula1);

            if (emp1 != null)
            {

                Console.Write("Informe o percentual que deseja aumentar: ");
                double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp1.AumentarSalario(Matricula1, Porcentagem);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Id não existente.");
                Console.WriteLine();
            }
            foreach (var item in N)
            {
                Console.WriteLine(item);

            }


        }
    }
}
