//Documento separado para deixar mais fácil de visualizar a parte do código referente ao txt.
class Parte_pro_txt {
    //Pega os dados do txt para mandar para o código, código do voo, local de destino do voo e quantos lugares vai ter no voo. 
        public static void Importar_dados_do_voo() {
                //Declaração de método
            string caminho_do_arquivo = "txt/voos.txt";
            // Declara variável com o caminho para encontrar o arquivo de texto com os dados iniciais do programa.
            string[] linhas = File.ReadAllLines(caminho_do_arquivo);
            /*Cria um vetor de linhas obtendo(lendo) o valor de todas as linhas de dentro do arquivo, para encontrar o caminho, segue a varíavel de caminho. Cada linha ganha um valor a mais para identificação.*/
            for (int i = 0; i < linhas.Length; i++)
            //Faz um for que cria uma variável inteira i e faz ela percorrer cada (vetor)linha de acordo com o indicado, ao final soma e repete o processo para a próxima (vetor)linha.
            {
                string[] dados = linhas[i].Split('|');
                //Vetor para armazenar dados advindos das linhas, referente a linha indicada no i, é separado internamente pela barra especial |
                Program.codigo[i] = dados[0].Trim();
                // Vai no elemento i do vetor de codigo do voo e guarda 
                Program.destinosdosvoos[i] = dados[1].Trim();
                Program.assentosdisponiveis[i] = int.Parse(dados[2].Trim());
            }
        Console.WriteLine("Dados dos voos importados do arquivo txt com sucesso!");
        }
        
        public static void Exportar_dados_para_arquivo_txt() {
            /*Cria o arquivo txt ou atualiza, conforme os dados preenchidos durante a ativação do código.*/
        using (StreamWriter writer = new StreamWriter("txt/relatorio.txt"))
        {
            for (int i = 0; i < Program.codigo.Length; i++)
            {
                int reservados = 50 - Program.assentosdisponiveis[i];
                writer.WriteLine($"Voo {Program.codigo[i]} - Destino: {Program.destinosdosvoos[i]}");
                writer.WriteLine($"Total de assentos reservados: {reservados}");
                writer.WriteLine($"Total de assentos disponíveis: {Program.assentosdisponiveis[i]}");
                writer.WriteLine();
            }
        }
        Console.WriteLine("Dados exportados com sucesso!");
    }
}

