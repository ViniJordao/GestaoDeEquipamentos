using System;

namespace GestaoDeEquipamentos

{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;


            Console.Clear();
            MenuInicial();

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();

                DateTime[] datafab = new DateTime[300];
                string[] nomeEqui = new string[300];
                string[] fabricanteEqui = new string[300];
                int Id = 0;
                double[] precoEqui = new double[300];
                int[] serieEqui = new int[300];

                Console.Clear();

                while (true)
                {
                    Console.Clear();

                    int opcaoEqui;
                    MenuEquipamentos();

                    opcaoEqui = Convert.ToInt32(Console.ReadLine());

                    if (opcaoEqui == 1)
                    {
                        Console.Clear();
                        RegistarEqui(datafab, nomeEqui, fabricanteEqui, Id, precoEqui, serieEqui);
                        Id++;
                    }

                    if (opcaoEqui == 2)

                    {
                        Console.Clear();

                        Console.WriteLine("Digite o ID do produto para editar: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < Id; i++)
                        {
                            if (serieEqui[i] == serieBusca)
                            {
                                EditarEqui(datafab, nomeEqui, fabricanteEqui, Id, precoEqui, serieEqui, i);
                            }
                        }
                    }
                    if (opcaoEqui == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o ID para editar: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < Id; i++)
                        {
                            if (serieEqui[i] == serieBusca)
                            {
                                serieEqui[i] = 0;
                                nomeEqui[i] = "";
                                fabricanteEqui[i] = "";
                                precoEqui[i] = 0;
                                datafab[i] = Convert.ToDateTime("00,00,0000");
                            }
                        }
                    }
                    if (opcaoEqui == 4)
                    {
                        for (int i = 0; i < Id; i++)
                        {
                            Console.WriteLine($"ID:{serieEqui[i]} nome do produto: {nomeEqui[i]}" +
                            $" fabricante do produto: {fabricanteEqui[i]} preço do produto: {precoEqui[i]} data de fabricação: {datafab[i]}");
                        }
                        Console.ReadLine();
                    }

                    else if (opcaoEqui == 5)

                    {
                        Console.WriteLine("Até mais :)");
                        Environment.Exit(1);
                    }

                }
            }
            if (opcao == 2)
            {
                Console.Clear();
                DateTime[] data = new DateTime[300];
                string[] nomeChamado = new string[300];
                string[] descricaoChamado = new string[100];
                string[] equipamentosChamado = new string[300];
                int contId = 0;
                Console.Clear();

                while (true)
                {
                    Console.Clear();

                    int opChamado;
                    MenuChamados();
                    opChamado = Convert.ToInt32(Console.ReadLine());

                    if (opChamado == 1)

                    {
                        Console.Clear();
                        OpcoesRegistraChamado(data, nomeChamado, descricaoChamado, equipamentosChamado, contId);
                        contId++;

                    }

                    if (opChamado == 2)

                    {
                        Console.Clear();

                        Console.WriteLine("Digite a titulo do chamado para editar: ");
                        string titulo = Console.ReadLine();

                        for (int i = 0; i < contId; i++)

                        {
                            if (nomeChamado[i] == titulo)
                            {
                                Console.Clear();
                                OpcoesEditChamado(data, nomeChamado, descricaoChamado, equipamentosChamado, contId, i);
                            }
                        }

                    }
                    if (opChamado == 3)

                    {
                        Console.Clear();

                        Console.WriteLine("Insira o titulo para deletar: ");
                        string tituloDel = Console.ReadLine();

                        for (int i = 0; i < contId; i++)

                        {
                            if (nomeChamado[i] == tituloDel)
                            {
                                nomeChamado[i] = "";
                                descricaoChamado[i] = "";
                                equipamentosChamado[i] = "";
                                data[i] = Convert.ToDateTime("00,00,0000");
                            }
                        }

                    }
                    if (opChamado == 4)
                    {
                        for (int i = 0; i < contId; i++)
                        {
                            string diasDifere = (DateTime.Now - data[i]).ToString("dd");
                            Console.WriteLine($"Título do chamado:{nomeChamado[i]} descrição do chamado: {descricaoChamado[i]} equipamento: {equipamentosChamado[i]} dias em aberto: {diasDifere}");
                        }
                        Console.ReadLine();
                    }
                    else if (opChamado == 5)
                    {
                        Console.WriteLine("Até mais :)");
                        Environment.Exit(1);
                    }
                }
            }
            if (opcao == 3)
            {
                Console.WriteLine("Até mais :)");
                Environment.Exit(1);
            }
        }

        private static void OpcoesEditChamado(DateTime[] data, string[] nomeChamado, string[] descricaoChamado, string[] equipamentosChamado, int contadorId, int i)
        {
            Console.WriteLine("Título do chamado: ");
            nomeChamado[i] = Console.ReadLine();
            Console.WriteLine("Descricao do produto: ");
            descricaoChamado[i] = Console.ReadLine();
            Console.WriteLine("Equipamento: ");
            equipamentosChamado[i] = Console.ReadLine();
            Console.WriteLine("Data (DD/MM/AAAA): ");
            data[contadorId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void OpcoesRegistraChamado(DateTime[] data, string[] nomeChamado, string[] descricaoChamado, string[] equipamentosChamado, int contadorId)
        {
            Console.WriteLine("Título do chamado: ");
            nomeChamado[contadorId] = Console.ReadLine();
            Console.WriteLine("Descricao do produto: ");
            descricaoChamado[contadorId] = Console.ReadLine();
            Console.WriteLine("Equipamento: ");
            equipamentosChamado[contadorId] = Console.ReadLine();
            Console.WriteLine("Data (DD/MM/AAAA): ");
            data[contadorId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void RegistarEqui(DateTime[] data, string[] nomePro, string[] fabricantePro, int countId, double[] precoProduto, int[] serieProduto)
        {
            Console.WriteLine("Nome do Produto: ");
            nomePro[countId] = Console.ReadLine();
            Console.WriteLine("Preço do produto: ");
            precoProduto[countId] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número de Série: ");
            serieProduto[countId] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Data (DD/MM/AAAA):");
            data[countId] = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Fabricante do produto: ");
            fabricantePro[countId] = Console.ReadLine();

        }

        private static void EditarEqui(DateTime[] data, string[] nomePro, string[] fabricantePro, int countId, double[] precoProduto, int[] serieProduto, int i)
        {
            Console.WriteLine("N° de série: ");
            serieProduto[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome do produto: ");
            nomePro[i] = Console.ReadLine();
            Console.WriteLine("Preço do Produto: ");
            precoProduto[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fabricante do produto: ");
            fabricantePro[i] = Console.ReadLine();
            Console.WriteLine("Data (DD/MM/AAAA):");
            data[countId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void MenuChamados()
        {
            Console.WriteLine("Digite 1 para Registrar");
            Console.WriteLine("Digite 2 para editar");
            Console.WriteLine("Digite 3 para deletar");
            Console.WriteLine("Digite 4 para visualizar");
            Console.WriteLine("Digite 5 para sair");
        }

        private static void MenuEquipamentos()
        {
            Console.WriteLine("Digite 1 para Registar");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Deletar");
            Console.WriteLine("Digite 4 para Visualizar");
            Console.WriteLine("Digite 5 para Sair");
        }

        private static void MenuInicial()
        {
            Console.WriteLine("-------------Escolha sua opção-------------");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para Equipamentos");
            Console.WriteLine();
            Console.WriteLine("Digite 2 para Chamados");
            Console.WriteLine();
            Console.WriteLine("Digite 3 para Sair");
        }
    }
}
