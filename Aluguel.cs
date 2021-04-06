using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class Aluguel
    {
        private string _id;
        private string _cliente;
        private string _locadora;
        private DateTime _inicio;
        private DateTime _final;
        private bool desativado;

        public string Id { get => _id; set => _id = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string Locadora { get => _locadora; set => _locadora = value; }
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime Final { get => _final; set => _final = value; }
        public bool Desativado { get => desativado; set => desativado = value; }

        public Aluguel(string id, string cliente, string locadora, DateTime inicio, DateTime final)
        {
            Id = id;
            Cliente = cliente;
            Locadora = locadora;
            Final = final;
        }
    }
}
