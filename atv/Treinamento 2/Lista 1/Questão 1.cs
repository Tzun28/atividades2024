using System;
    /*1. Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas,
considerando peso 2 para a primeira nota e peso 3 para a segunda nota*/
class Questaoumum {

public static void Rodar(){
    Console.WriteLine("Digite as duas notas");
    double z = double.Parse(Console.ReadLine());
    double x = double.Parse(Console.ReadLine());
    double h = ((z * 2)/5) + ((x * 3)/5);
    Console.WriteLine("O resultado é: " + h);

}
}