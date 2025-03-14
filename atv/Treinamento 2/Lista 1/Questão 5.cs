/*5. Faça um programa que receba o raio, calcule e mostre:
a) o comprimento de uma esfera, sabe-se que C = 2πR;
b) a área de uma esfera, sabe-se que A = πR2;
c) o volume de uma esfera, sabe-se que V = 4/3πR3.
Obs: Para calcular o raio ao quadrado ou ao cubo você pode usar a função Pow() como
abaixo:
Z = Math.Pow(x, y) // calcula a potência: XY e coloca o resultado na variável Z.
*/
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Questaocincoum {
    public static void Rodar() {
    
    string[] Nome;

    Console.WriteLine("Digite o seu nome");
    string Peganome = Console.ReadLine();
    Nome = Peganome.Split(" ");
    Console.Write(Nome[2]);
    Console.WriteLine(" " + Nome[0]);


    }
}