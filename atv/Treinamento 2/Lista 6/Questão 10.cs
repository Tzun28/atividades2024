/*
10. Fazer um programa que leia a quantidade de segundos passados desde o início do dia e
transforme em: horas, minutos e segundos
*/
class Questaodezseis {

public static void Rodar(){
    Console.WriteLine("Digite as duas notas");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = ((a * 2) + (b * 3)) / 5;
    Console.WriteLine("O resultado é: " + c);

}
}