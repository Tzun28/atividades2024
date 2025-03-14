using System;
using System.IO;

//Program classe do dotnet para teste
class Program
{
    public static string[] codigo = new string[5];
    //Declaração de váriavel para armazenar o código dos voos
    public static string[] destinosdosvoos = new string[5] { "Ibirité", "Contagem", "Betim", "Ladainha", "Novo Cruzeiro" };
    public static int[] assentosdisponiveis = new int[5];
    public static string[,] reservasnovoo = new string[5, 50];

    private static void Main(string[] args)
    {
        int opcao = 0;

        for (;opcao != 6;) {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1. Importar dados dos voos");
            Console.WriteLine("2. Realizar reserva");
            Console.WriteLine("3. Cancelar reserva");
            Console.WriteLine("4. Consultar assentos disponíveis");
            Console.WriteLine("5. Relatório de ocupação de voos");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Parte_pro_txt.Importar_dados_do_voo();
                    break;
                case 2:
                    RealizarReserva();
                    break;
                case 3:
                    CancelarReserva();
                    break;
                case 4:
                    ConsultarAssentosDisponiveis();
                    break;
                case 5:
                    RelatorioOcupacaoVoos();
                    break;
                case 6:
                    Parte_pro_txt.Exportar_dados_para_arquivo_txt();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }



    static void RealizarReserva()
    {
        Console.Write("Informe o código do voo: ");
        string codigoVoo = Console.ReadLine();
        int indexVoo = Array.IndexOf(codigo, codigoVoo);

        if (indexVoo == -1)
        {
            Console.WriteLine("Voo não encontrado!");
            return;
        }

        Console.Write("Informe o número da poltrona ( de 1 a 50): ");
        int numeroAssento = int.Parse(Console.ReadLine()) - 1;

        if (numeroAssento < 0 || numeroAssento >= 50)
        {
            Console.WriteLine("Número de poltrona inválida!");
            return;
        }

        if (!string.IsNullOrEmpty(reservasnovoo[indexVoo, numeroAssento]))
        {
            Console.WriteLine("Essa poltrona já está ocupado!");
            return;
        }

        Console.Write("Informe o seu nome: ");
        string nome = Console.ReadLine();
        reservasnovoo[indexVoo, numeroAssento] = nome;
        assentosdisponiveis[indexVoo]--;
        Console.WriteLine("Reserva realizada com sucesso!");
    }

    static void CancelarReserva()
    {
        Console.Write("Informe o código do voo: ");
        string codigoVoo = Console.ReadLine();
        int indexVoo = Array.IndexOf(codigo, codigoVoo);

        if (indexVoo == -1)
        {
            Console.WriteLine("Voo não encontrado!");
            return;
        }

        Console.Write("Informe o número do assento (1 a 50): ");
        int numeroAssento = int.Parse(Console.ReadLine()) - 1;

        if (numeroAssento < 0 || numeroAssento >= 50)
        {
            Console.WriteLine("Número de assento inválido!");
            return;
        }

        if (string.IsNullOrEmpty(reservasnovoo[indexVoo, numeroAssento]))
        {
            Console.WriteLine("Assento não está reservado!");
            return;
        }

        reservasnovoo[indexVoo, numeroAssento] = null;
        assentosdisponiveis[indexVoo]++;
        Console.WriteLine("Reserva cancelada com sucesso!");
    }

    static void ConsultarAssentosDisponiveis()
    {
        for (int i = 0; i < codigo.Length; i++)
        {
            Console.WriteLine($"Voo {codigo[i]} - Destino: {destinosdosvoos[i]}");
            Console.Write("Assentos disponíveis: ");
            for (int j = 0; j < 50; j++)
            {
                if (string.IsNullOrEmpty(reservasnovoo[i, j]))
                {
                    Console.Write((j + 1) + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static void RelatorioOcupacaoVoos()
    {
        Console.Write("Informe o código do voo (01 a 05): ");
        string codigoVoo = Console.ReadLine();
        int indexVoo = Array.IndexOf(codigo, codigoVoo);

        if (indexVoo == -1)
        {
            Console.WriteLine("Voo não encontrado!");
            return;
        }

        Console.WriteLine($"Voo {codigo[indexVoo]} - Destino: {destinosdosvoos[indexVoo]}");
        for (int i = 0; i < 50; i++)
        {
            string status = string.IsNullOrEmpty(reservasnovoo[indexVoo, i]) ? "Disponível" : reservasnovoo[indexVoo, i];
            Console.WriteLine($"Assento {i + 1}: {status}");
        }
    }

}
