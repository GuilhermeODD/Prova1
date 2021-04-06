using System;

namespace Prova1
{
    class ConsoleLocadora
    {
        public static int IdCarros = 13;
        public static string LocadoraSelecionada = "";
        public static string ClienteSelecionado = "";
        public static string VeiculoSelecionado = "";
        public static void Main()
        {
            int c = 0;
            RedeLocadora.AdicionarLocadora(new Locadora("Locadora 5cão", "Rua shakethatas 200"));
            RedeLocadora.AdicionarLocadora(new Locadora("Locadora A vida é um desafio", "Rua racionais 7"));
            RedeLocadora.Clientes.Add(new Cliente("Guilherme ODD", "113.776.249-78"));
            RedeLocadora.Clientes.Add(new Cliente("Nathan Henrique", "007.290.900-24"));
            RedeLocadora.Clientes.Add(new Cliente("MV Bill", "169.573.600-47"));
            RedeLocadora.Clientes.Add(new Cliente("Camilla Garcia", "199.141.225-01"));
            foreach (Locadora loc in RedeLocadora.Locadoras)
            {
                if (loc.Nome == "Locadora 5cao")
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1", "Locadora 5cao", "Carro", 0, "MVJ-1189", 15000, "Ford", "Monza", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("2", "Locadora 5cao", "Carro", 0, "SMI-4605", 40000, "Gt", "V8", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("3", "Locadora 5cao", "Carro", 0, "HKI-4756", 30000, "Chevvete", "---", true));

                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("4", "Locadora 5cao", "Avião", 1000, "", 0, "NNAIR", "999", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("5", "Locadora 5cao", "Avião", 1200, "", 0, "Boeing", "476", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("6", "Locadora 5cao", "Avião", 8000, "", 0, "Flylikeairs", "A770", false));
                }
            }
            foreach (Locadora loc in RedeLocadora.Locadoras)
            {
                if (loc.Nome == "Locadora A vida é um desafio")
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("7", "Locadora A vida é um desafio", "Carro", 0, "Edi-4039", 10000, "toyota", "Corollaxenon", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("8", "Locadora A vida é um desafio", "Carro", 0, "KZJ-1048", 280000, "Mazda", "Cx-30", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("9", "Locadora A vida é um desafio", "Carro", 0, "HVW-3450", 36000, "Nissan", "kicks", true));

                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("10", "Locadora A vida é um desafio", "Avião", 1400, "", 0, "Teco-Teco", "000", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("11", "Locadora A vida é um desafio", "Avião", 1800, "", 0, "Neyair", "546", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("12", "Locadora A vida é um desafio", "Avião", 16000, "", 0, "Boeing", "010", false));
                }
            }
            while (c == 0)
            {
                MostrarMenu();
            }
        }


        public static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("<--------------------------------------->\n " +
                "      Sistema de Locadoras\n " +
                "\n" +
                $"Locadora selecionada: {LocadoraSelecionada}\n" +
                $"Cliente selecionado: {ClienteSelecionado}\n" +
                "     \n" +
                "1 - Criar Locadora \n" +
                "2 - Remover Locadora\n" +
                "3 - Listar Locadoras\n" +
                "4 - Selecionar Locadora\n" +
                "\n" +
                $"5 - Adicionar veículo: {LocadoraSelecionada}\n" +
                "6 - Listar Veiculos Disponiveis\n" +
                "7 - Listar Carros Disponíveis\n" +
                "8 - Listar Aviões Disponíveis\n" +
                "9 - Listar Todos Os Veiculo\n" +
                "\n" +
                "10 - Cadastrar Cliente\n" +
                "11 - Listar Clientes\n" +
                "12 - Selecionar Cliente\n" +
                "\n" +
                "13 - Iniciar Aluguel\n" +
                "14 - Devolver Veículo\n" +
                "15 - Listar Alugueis\n" +
                "16 - ListarAlugueisCliente\n" +
                "<------------------------------------------->");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    CriarLocadora();
                    break;
                case 2:
                    RemoverLocadora();
                    break;
                case 3:
                    ListarLocadoras();
                    break;
                case 4:
                    SelecionarLocadora();
                    break;
                case 5:
                    AdicionarVeiculo();
                    break;
                case 6:
                    ListarVeiculosDisponíveis();
                    break;
                case 7:
                    ListarCarrosDisponíveis();
                    break;
                case 8:
                    ListaAviõesDisponíveis();
                    break;
                case 9:
                    ListarTodosOsVeiculos();
                    break;
                case 10:
                    CadastrarCliente();
                    break;
                case 11:
                    ListarClientes();
                    break;
                case 12:
                    SelecionarCliente();
                    break;
                case 13:
                    IniciarAluguel();
                    break;
                case 14:
                    DevolverVeiculo();
                    break;
                case 15:
                    ListarAlugueis();
                    break;
                case 16:
                    AluguelPorCliente();
                    break;
                default:
                    Console.WriteLine("Comando incorreto");
                    break;
            }
        }
        public static void CriarLocadora()
        {
            Console.WriteLine("");
            Console.WriteLine("Criando locadora..\n" +
            "Insira seu nome (Locadora) :");
            string n = Console.ReadLine();
            Console.WriteLine("Insira o endereço da locadora " + n);
            string e = Console.ReadLine();
            RedeLocadora.AdicionarLocadora(new Locadora(n, e));
            Console.WriteLine($"Locadora {n}  Adicionada com sucesso!!!");
        }
        public static void ListarLocadoras()
        {
            RedeLocadora.ListarLocadoras();
        }
        public static void RemoverLocadora()
        {
            RedeLocadora.ListarLocadoras();
            Console.WriteLine("Qual locadora voce deseja remover?");
            string Remover = Console.ReadLine();
            if (RedeLocadora.RemoverLocadora(Remover))
            {
                Console.WriteLine($"{Remover} removida :(");
            }
            else
            {
                Console.WriteLine($"Não foi possivel encontrar a locadora... {Remover}");
            }

        }
        public static void SelecionarLocadora()
        {
            string LocadoraBackup = LocadoraSelecionada;
            LocadoraSelecionada = "";
            RedeLocadora.ListarLocadoras();
            Console.WriteLine(" \n" +
                "Qual locadora voce desejar selecionar?");
            string Selecionar = Console.ReadLine();
            foreach (Locadora loc in RedeLocadora.Locadoras)
            {
                if (loc.Nome.Equals(Selecionar))
                {
                    LocadoraSelecionada = loc.Nome;
                    Console.WriteLine($"{Selecionar}  selecionada!");
                }
            }
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine($"{Selecionar} não foi encontrado.");
                LocadoraSelecionada = LocadoraBackup;
            }
        }
        public static void ListarVeiculosDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadora.Locadoras)
                {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarVeiculosDisponiveis(LocadoraSelecionada);
                    }
                }
            }
        }
        public static void ListaAviõesDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadora.Locadoras)
                {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarAviõesDisponiveis(LocadoraSelecionada);
                    }
                }
            }
        }
        public static void ListarCarrosDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadora.Locadoras)
                {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarCarrosDisponiveis(LocadoraSelecionada);
                    }
                }
            }
        }
        public static void ListarTodosOsVeiculos()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadora.Locadoras)
                {
                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarTodosOsVeículos(LocadoraSelecionada);
                    }
                }
            }
        }


        public static void CadastrarCliente()
        {

            Console.WriteLine(" \n" +
                "Adicionando Cliente... \n" +
                "Insira o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine($"Digite o cpf de {nomeCliente}: ");
            string cpfCliente = Console.ReadLine();

            RedeLocadora.Clientes.Add(new Cliente(nomeCliente, cpfCliente));

            Console.WriteLine($"Cliente {nomeCliente} foi adicionado com sucesso!!");

        }
        public static void ListarClientes()
        {
            Console.WriteLine("");
            Console.WriteLine("Lista de todos os clientes cadastrados:");
            foreach (Cliente c in RedeLocadora.Clientes)
            {
                Console.WriteLine($"Nome: {c.Nome} | CPF: {c.Cpf}");
            }
        }
        public static void SelecionarCliente()
        {

            string ClienteBackup = ClienteSelecionado;
            ClienteSelecionado = "";
            ListarClientes();
            Console.WriteLine(" \n" +
            "Qual Cliente você deseja selecionar? ");
            string Selecionar = Console.ReadLine();
            foreach (Cliente c in RedeLocadora.Clientes)
            {
                if (c.Nome.Equals(Selecionar))
                {
                    ClienteSelecionado = c.Nome;
                    Console.WriteLine($"{c.Nome} selecionado!");
                }

            }
            if (ClienteSelecionado == "")
            {
                Console.WriteLine($"{Selecionar} não foi encontrado.");
                ClienteSelecionado = ClienteBackup;
            }



        }
        public static void IniciarAluguel()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
                return;
            }
            if (ClienteSelecionado == "")
            {
                Console.WriteLine("Selecione um cliente primeiro");
                return;
            }
        Listar:
            Locadora.ListarVeiculosDisponiveis(LocadoraSelecionada);


            Console.WriteLine(" \n" +
                "Qual veículo deseja alugar? (Digite o Id do Veiculo)");

            string idVeiculoAlugar = Console.ReadLine();
            bool Achou = false; ;

            foreach (VeiculoAluguel v in Locadora.VeiculosAluguel)
            {
                if (v.Id.Equals(idVeiculoAlugar))
                {
                    if (v.Locadora == LocadoraSelecionada)
                    {
                        if (v.Alugado == false)
                        {
                            Achou = true;
                            Console.WriteLine("Veiculo selecionado:");
                            if (v.Tipo == "Carro")
                            {
                                Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                            }
                            if (v.Tipo == "Avião")
                            {
                                Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Horas de Voo: {v.Horasvoo} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                            }
                            Console.WriteLine("");
                            VeiculoSelecionado = v.Id;
                            Console.WriteLine("Qual o tempo de aluguel?");
                            int dias = int.Parse(Console.ReadLine());
                            var hoje = DateTime.Now;
                            var AlugarDias = hoje.AddDays(dias);
                            Locadora.AlugueisAtuais.Add(new Aluguel(v.Id, ClienteSelecionado, LocadoraSelecionada, hoje, AlugarDias));
                            Console.WriteLine("");
                            Console.WriteLine("Aluguel efetuado!\n" +
                                " \n" +
                                $"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo}\n" +
                                $"Alugado por: {ClienteSelecionado}\n" +
                                $"Locadora: {LocadoraSelecionada}\n" +
                                $"Data inicial: {hoje}\n" +
                                $"Data para devolução: {AlugarDias}");
                            v.Alugado = true;

                        }

                    }
                }
            }
            if (Achou == false)
            {
                Console.WriteLine("");
                Console.WriteLine($"Nenhum veículo disponível em {LocadoraSelecionada} com o ID: {idVeiculoAlugar}");
                Console.WriteLine("");
                goto Listar;
            }

        }
        public static void DevolverVeiculo()
        {
        Devolver:
            ListarAlugueis();
            Console.WriteLine("");
            Console.WriteLine("Qual dos alugueis deseja devolver? (Digite o Id do veiculo)");
            string idDevolver = Console.ReadLine();
            bool existe = false;
            foreach (Aluguel a in Locadora.AlugueisAtuais)
            {
                if (a.Id.Equals(idDevolver))
                {
                    Console.WriteLine($"Aluguel ID: {a.Id} foi devolvido a {a.Locadora}");
                    foreach (VeiculoAluguel v in Locadora.VeiculosAluguel)
                    {
                        if (v.Id.Equals(idDevolver))
                        {
                            v.Alugado = false;
                            a.Desativado = true;
                            a.Id = "0";
                        }
                    }
                    existe = true;
                }

            }
            if (existe == false)
            {
                Console.WriteLine($"Nenhum aluguel com o ID {idDevolver} foi encontrado");
                goto Devolver;
            }
        }
        public static void ListarAlugueis()
        {
            Console.WriteLine(" \n" +
            "Alugueis cadastrados:");
            foreach (Aluguel a in Locadora.AlugueisAtuais)
            {
                foreach (VeiculoAluguel v in Locadora.VeiculosAluguel)
                {
                    if (v.Id.Equals(a.Id))
                    {
                        if (v.Alugado == true || a.Desativado == false)
                        {
                            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                                $"Aluguel ID: {a.Id}\n" +
                                $"Veículo {v.Marca} {v.Modelo}\n" +
                                $"Alugado por: {a.Cliente}\n" +
                                $"Locado por {a.Locadora}\n" +
                                $" \n" +
                                $"Inicio: {a.Inicio}\n" +
                                $"Devolução: {a.Final}\n" +
                                $"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        }
                    }
                }

            }
        }

        public static void AluguelPorCliente()
        {
            ListarClientes();
            Console.WriteLine("Qual dos clientes deseja listar os alugueis?");
            string selecionado = Console.ReadLine();
            int qnt = 0;
            bool encontrado = false;
            foreach (Cliente c in RedeLocadora.Clientes)
            {
                if (c.Nome.Equals(selecionado))
                {
                    encontrado = true;
                }
            }
            foreach (Aluguel a in Locadora.AlugueisAtuais)
            {
                if (a.Cliente.Equals(selecionado))
                {
                    encontrado = true;
                    Console.WriteLine($"------------------------------\n" +
                    $"Aluguel ID: {a.Id}\n" +
                    $"Alugado por: {a.Cliente}\n" +
                    $" \n" +
                    $"Inicio: {a.Inicio}\n" +
                    $"Devolução: {a.Final}\n" +
                    $"-------------------------------------");
                    qnt++;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine($"{selecionado} não foi encontrado.");
                return;
            }
            if (qnt == 0)
            {
                Console.WriteLine($" \n" +
                    $"Não foi encontrado nenhum aluguel ativo para {selecionado}");

            }
        }
        public static void AdicionarVeiculo()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
                return;
            }
            string Placa = "";
            float Quilometragem = 0;
            float HorasVoo = 0;
            string TipoReal = "";
            Console.WriteLine($"Adicionando veículo a {LocadoraSelecionada}...\n" +
                "Qual o tipo do veículo? (Carro/Aviao)");
        Tipo:
            string Tipo = Console.ReadLine();
            if (Tipo != "Carro" && Tipo != "Aviao")
            {
                Console.WriteLine("Invalido! (Carro/Aviao)");
                goto Tipo;
            }
            if (Tipo == "Carro")
            {
                Console.WriteLine("Qual a placa do carro?");
                Placa = Console.ReadLine();
                Console.WriteLine("Qual a quilometragem do carro?");
                Quilometragem = float.Parse(Console.ReadLine());
                TipoReal = "Carro";
            }
            if (Tipo == "Aviao")
            {
                Console.WriteLine("Qual o tempo de voo?");
                HorasVoo = float.Parse(Console.ReadLine());
                TipoReal = "Avião";

            }

            Console.WriteLine("Qual a marca do veículo?");
            string Marca = Console.ReadLine();

            Console.WriteLine("Qual o modelo do veículo?");
            string Modelo = Console.ReadLine();

            foreach (Locadora loc in RedeLocadora.Locadoras)
            {
                if (loc.Nome.Equals(LocadoraSelecionada))
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel(IdCarros.ToString(), LocadoraSelecionada, TipoReal, HorasVoo, Placa, Quilometragem, Marca, Modelo, false));
                    IdCarros += 1;
                }
            }

        }
    }


}


