using System.Globalization;

namespace ExercicioProposto_MetodosAbstratos.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            double valorImposto = 0;

            if (RendaAnual < 20000.00)
            {
                if (GastoSaude >= 0)
                {
                    valorImposto = (RendaAnual * 0.15) - (GastoSaude * 0.5);
                }
                else
                {
                    valorImposto = RendaAnual * 0.15;
                }
            }
            else
            {
                if (GastoSaude >= 0)
                {
                    valorImposto = (RendaAnual * 0.25) - (GastoSaude * 0.5);
                }
                else
                {
                    valorImposto = RendaAnual * 0.25;
                }
            }

            return valorImposto;
        }
    }
}
