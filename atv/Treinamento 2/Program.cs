using System;

class Treinamento {

    private static void Main() {
        Console.WriteLine("Escolha que tipo de algoritmo você quer:");
        string Menu = Console.ReadLine();
        if (Menu == null) { Console.WriteLine("Esse algoritmo não existe"); return;}
        switch (Menu.ToLower()) {
            case "calculadora":
                BackEnd.Calculadora();
                break;
            case "roleplayzada":
                Roleplaytotal.Roleplayzada();
                break;
            case "1":
                Listaum.Funciona();
                break;
            case "6":
                Listaseis.Funciona();
                break;
            default:
                Console.WriteLine("Esse algoritmo não existe");
                break;            

        }
    }
}
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome completo: ");
        string nomeCompleto = Console.ReadLine();

        // Divide o nome completo em partes
        string[] partesNome = nomeCompleto.Split(' ');

        // Verifica se há pelo menos dois nomes
        if (partesNome.Length >= 2)
        {
            // Pega o primeiro e o último nome
            string primeiroNome = partesNome[0];
            string ultimoNome = partesNome[partesNome.Length - 1];

            // Concatena os nomes na ordem desejada
            string nomeReformatado = $"{ultimoNome} {primeiroNome}";

            // Exibe o resultado
            Console.WriteLine($"Nome reformatado: {nomeReformatado}");
        }
        else
        {
            Console.WriteLine("Por favor, insira pelo menos dois nomes.");
        }
    }
}
*/