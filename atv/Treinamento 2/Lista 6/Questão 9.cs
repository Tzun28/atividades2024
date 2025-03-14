/*
9. Fazer um programa que leia a hora, minutos e segundos e exiba a quantidade de segundos
decorridos desde o início do dia
*/
class Questaonoveseis {

public static void Rodar(){
    Console.WriteLine("Digite as duas notas");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = ((a * 2) + (b * 3)) / 5;
    Console.WriteLine("O resultado é: " + c);

}
}