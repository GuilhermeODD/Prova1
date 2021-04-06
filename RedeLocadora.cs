using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class RedeLocadora

    {

        private static string _nome;
        private static List<Cliente> _clientes = new List<Cliente>();
        private static List<Locadora> _locadoras = new List<Locadora>();

        public static string Nome { get => _nome; set => _nome = value; }
        public static List<Locadora> Locadoras { get => _locadoras; private set => _locadoras = value; }
        public static List<Cliente> Clientes { get => _clientes; private set => _clientes = value; }

        public static void AdicionarLocadora(Locadora loc)
        {
            Locadoras.Add(loc);
        }
        public static bool RemoverLocadora(string Nome)
        {
            foreach (Locadora loc in Locadoras)
            {
                if (loc.Nome.Equals(Nome))
                {
                    Locadoras.Remove(loc);
                    return true;
                }
            }
            return false;
        }
        public void AdicionarCliente(Cliente c)
        {
            Clientes.Add(c);
        }
        public static void ListarLocadoras()
        {
            if (Locadoras.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Nada foi adicionado.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("+---------------------------------+");
                foreach (Locadora loc in Locadoras)
                {
                    Console.WriteLine($"Nome: {loc.Nome} | Endereço: {loc.Endereço}");
                }
                Console.WriteLine("=----------------------------------=");
                Console.WriteLine("");
            }
        }
    }
}

