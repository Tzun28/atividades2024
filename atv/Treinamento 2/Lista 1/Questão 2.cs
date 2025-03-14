using System;
/*2. Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo-
se que este sofreu um desconto de 10%.*/
class Questaodoisum {

public static void Rodar(){
    Console.WriteLine("Digite o preço do produto");
    double a = double.Parse(Console.ReadLine());
    a = a * 0.9;
    Console.WriteLine("O novo preço do produto é " + a + "." );

}
}