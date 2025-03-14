
//Questão N°1
//Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas, considerando peso 2 para a primeira nota e peso 3 para a segunda nota

using System;

class Program 
{
  public static void Main () 
    {
      double No1, No2, MPonde;
        //Declaração das váriaveis, declarei com double para poder escrever a nota com casas decimais também
      Console.WriteLine ("Digite a primeira nota");
        // Pedi para digitar a primeira nota
    No1 = double.Parse(Console.ReadLine());
        //Leitura da Nota e armazenar na primeira váriavel
      Console.WriteLine("Digite a segunda nota");
        //Pedi para digitar a segunda nota 
    No2 = double.Parse(Console.ReadLine());
        //Agora a leitura da segunda nota para a segunda váriavel
    MPonde = (No1 * 2 + No2 * 3)/5;
        //Cálculo da média ponderada com a primeira nota sendo multiplicada pelo peso 2 e a segunda nota sendo multiplicada pelo peso 3, depois dividi pela soma dos pesos que é 5
    Console.WriteLine("A nota final é:"+ MPonde );
      //Exibição da nota final
    }
}

