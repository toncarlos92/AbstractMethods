using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            double valorImposto = 0;

            if (Funcionarios > 10)
            {
                valorImposto = RendaAnual * 0.14;
            }
            else
            {
                valorImposto = RendaAnual * 0.16;
            }

            return valorImposto;
        }
    }
}
