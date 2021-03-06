using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    class ContaInvestimento : ContaBancaria
    {

        public double ValorInvestido { get; private set; }


        public ContaInvestimento(Titular titular) : base(titular)
        {
        }

        public ContaInvestimento(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("******** Extrato Conta Investimento ********");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);

            foreach (var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }
            Console.WriteLine("Saldo atual:  R$" + Saldo);
            Console.WriteLine();

            Console.WriteLine("********************************************");
            Console.WriteLine("************* Fim do extrato ***************");
            Console.WriteLine("********************************************");
            Console.WriteLine();
        }
    }
}
