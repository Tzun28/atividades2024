/*
6. Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e mostre a
medida do terceiro ângulo. Sabe-se que a soma dos ângulos de um triângulo é 180.
*/
using System.IO.Compression;
using System.Reflection;

class Questaoseisum {
    static string[,] Sabio = new string [3,3];
public static void Rodar(){
    
    Console.WriteLine("Digite nome e sobrenome: ");
    for (int i = 0; i < 3; i++) {
        for ( int z = 0; z < 3; z++) {
            string Donos = Console.ReadLine();
            Sabio[i, z] = Donos;
        }
    }   
    for (int i = 0; i < 3; i++) {
            for ( int z = 0; z < 3; z++) {
        Console.Write($"{Sabio[i,z]} ");
            }
    }
    
    }
}
