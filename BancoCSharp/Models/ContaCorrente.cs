using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular) : base(titular)
        {
        }

        public ContaCorrente(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("********* Extrato Conta Corrente ********");
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);

            foreach (var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine("************ Fim do extrato *************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
        }
    }
}
