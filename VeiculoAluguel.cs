using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class VeiculoAluguel
    {
        public VeiculoAluguel(string id, string locadora, string tipo, float horasvoo, string placa, float quilometragem, string marca, string modelo, bool alugado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Alugado = alugado;
            Tipo = tipo;
            Horasvoo = horasvoo;
            Quilometragem = quilometragem;
            Placa = placa;
            Locadora = locadora;
        }

        private string _locadora;
        private string _id;
        private string _tipo;
        private string _marca;
        private string _modelo;
        private bool _alugado;
        private string _placa;
        private float _horasvoo;
        private float quilometragem;

        public string Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public bool Alugado { get => _alugado; set => _alugado = value; }
        public string Placa { get => _placa; set => _placa = value; }
        public float Horasvoo { get => _horasvoo; set => _horasvoo = value; }
        public float Quilometragem { get => quilometragem; set => quilometragem = value; }
        public string Locadora { get => _locadora; set => _locadora = value; }

    }


}

    


