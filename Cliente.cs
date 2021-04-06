using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class Cliente
    {
        private string _nome;
        private string _cpf;
        private static List<Aluguel> _alugueis;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public static List<Aluguel> Alugueis { get => _alugueis; set => _alugueis = value; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public void Alugar(VeiculoAluguel v, string Locadora, DateTime inicio, DateTime final)
        {
            Alugueis.Add(new Aluguel(v.Id, this.Nome, Locadora, inicio, final));
        }
    }
}


