using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap06_Fixacao
{
    class FolhaPagamento
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public FolhaPagamento(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;

        }

        public void AumentarSalario(int id, double aumento)
        {

            Salario = (Salario * aumento / 100.0) + Salario;
        }


        public override string ToString()
        {
            return Id + ", " + Nome + ", R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
