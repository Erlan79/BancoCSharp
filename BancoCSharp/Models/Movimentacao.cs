using BancoCSharp.Enums;
using System;

namespace BancoCSharp.Models
{
    class Movimentacao
    {
        private DateTime DataHoraMovimentacao { get; set; }
        private TipoMovimentacao TipoMovimentacao { get; set; }
        private double Valor { get; set; }

        public Movimentacao(TipoMovimentacao tipoMovimentacao, double valor)
        {
            TipoMovimentacao = tipoMovimentacao;
            DataHoraMovimentacao = DateTime.Now;
            Valor = valor;

        }

        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == TipoMovimentacao.SAQUE || this.TipoMovimentacao == TipoMovimentacao.TRANSFERENCIA)
                ? "-R$ " + Valor
                : "R$ " + Valor;
            
            return $"{DataHoraMovimentacao} hs  |  {TipoMovimentacao}  |  {valor}";
        }


        // 26/06/2022 as 16:25 .... SAQUE .... -R$ 10.00
        // 26/06/2022 as 16:28 .... DEPOSITO .... R$ 100.0 
    }
}
