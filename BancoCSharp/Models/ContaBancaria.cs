using System;
using System.Collections.Generic;

namespace BancoCSharp.Models
{
    abstract class ContaBancaria //PAI
    {
       #region Atributos

       public Titular Titular { get; set; }
       public double Saldo { get; private set; }
       public DateTime DataAbertura { get; private set; }  
       protected List<Movimentacao> Movimentacoes { get; set; }

       private readonly double VALOR_MINIMO = 10.0; // Constante

        #endregion


       #region Construtores
        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            DataAbertura = DateTime.Now;

            Movimentacoes = new List<Movimentacao>() // Object initializer
            {
                new Movimentacao(Enums.TipoMovimentacao.ABERTURA_CONTA, saldoAbertura)
            };

        }

        public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
            DataAbertura = DateTime.Now;
            Movimentacoes = new List<Movimentacao>() // Object initializer
            {
                new Movimentacao(Enums.TipoMovimentacao.ABERTURA_CONTA, Saldo)
            };
        }


        #endregion


        #region Métodos

        public void Depositar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O Valor mínimo para depósito é R$ " + VALOR_MINIMO);
            } 

            Saldo += valor;
            Movimentacoes.Add(new Movimentacao(Enums.TipoMovimentacao.DEPOSITO, valor));

        }

        public double Sacar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O Valor mínimo para saque é R$ " + VALOR_MINIMO);
            }
            else if (valor > Saldo)
            {
                throw new Exception("Saldo insulficiente para saque, Saldo atual é de R$ " + Saldo);
            }

            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(Enums.TipoMovimentacao.SAQUE, valor));

            return valor;

        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O valor mínimo para transferência é de R$ " + VALOR_MINIMO);
            }
            else if (valor > Saldo)
            {
                throw new Exception("Saldo insulficiente para transferência, Saldo atual é de R$ " + Saldo);
            }

            contaDestino.Depositar(valor);

            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(Enums.TipoMovimentacao.TRANSFERENCIA, valor));

        }

        // abstract - Todas as classes filhas tem que sobrescrever o método.
        // virtual - Se a classe filha quiser pode sobrescrever o método.
        // protected - permite acesso às classes filhas, mas proíbe a qualquer outro acesso externo.


        public abstract void ImprimirExtrato();
        //{
        //    Console.WriteLine("Imprimir extrato!");
        //}

        #endregion

    }
}
