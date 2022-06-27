

using BancoCSharp.Models;
using System;

namespace BancoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("********************** Banco CSharp *********************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine();


            var endereco = new Endereco
            {
                Cep = "40296720",
                Rua = "Sócrates Guanaes Gomes",
                Numero = 44
            };

            var titular01 = new Titular("José da Silva", "1234567891", "719939784545", endereco);
            var titular02 = new Titular("Maria da Silva", "99999999999", "71987444152", endereco);
            var titular03 = new Titular("Bruce Lee", "98765432112", "71985741255", endereco);

            var conta01 = new ContaCorrente(titular01, 100.0);
            var conta02 = new ContaInvestimento(titular02);
            var conta03 = new ContaPoupanca(titular02);

            conta01.Depositar(50.0);

            conta02.Depositar(500.0);
            conta02.Sacar(100.0);
            conta02.Transferir(conta03, 100.0);


            //conta03.Sacar(25.0);

            conta01.ImprimirExtrato();
            conta02.ImprimirExtrato();
            conta03.ImprimirExtrato();

            #region try catch
            /*
            var m1 = new Movimentacao(Enums.TipoMovimentacao.SAQUE, 100);
            var m2 = new Movimentacao(Enums.TipoMovimentacao.DEPOSITO, 100);

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            */
            /*
            try
            {
                //var valor = conta01.Sacar(10);
                //Console.WriteLine(valor);

                //conta01.Depositar(10.0);

                conta01.Transferir(conta02, 25.0);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            */
            #endregion

            #region consoles
            /*
            Console.WriteLine("Saldo Conta01: " + conta01.Saldo);
            Console.WriteLine("Extrato Conta01: ");
            conta01.ImprimirExtrato();

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            Console.WriteLine("Saldo Conta02: " + conta02.Saldo);
            Console.WriteLine("Extrato Conta02: ");
            conta02.ImprimirExtrato();

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            Console.WriteLine("Saldo Conta03: " + conta03.Saldo);
            Console.WriteLine("Extrato Conta03: ");
            conta03.ImprimirExtrato();

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            */
            #endregion


            Console.WriteLine();


        }
    }
}
