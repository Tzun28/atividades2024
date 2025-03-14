/*4. Faça um programa que receba o valor do salário mínimo atual e o valor do salário de um
funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.*/
using System.Security.Cryptography.X509Certificates;

class Questaoquatroum {

public static async void Rodar(){
    Console.WriteLine("Digite um valor para ser calculado em fatorial");
    int z = int.Parse(Console.ReadLine());
    for ( int a = z - 1; a >= 1; a--) {
            z = z * a;
    }
    Console.WriteLine(z);
}
}