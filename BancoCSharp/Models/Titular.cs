using System;

namespace BancoCSharp.Models
{
    class Titular
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Titular(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public Titular(string nome, string cPF, string telefone, Endereco endereco) : this(nome, cPF, telefone)
        {
            Endereco = endereco;
        }
    }
}
