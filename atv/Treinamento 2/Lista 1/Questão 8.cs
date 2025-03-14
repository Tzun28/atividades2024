/*
8. Fazer um programa que leia o valor de um salário a ser pago e informe a quantidade mínima de
notas que precisarão ser sacadas no banco para pagar o funcionário. As notas disponíveis são:
200, 100, 50, 20, 10, 5, 2 reais e 1 real
*/
class Questaooitoum {

public static void Rodar(){
    Console.WriteLine("Digite as duas notas");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = ((a * 2) + (b * 3)) / 5;
    Console.WriteLine("O resultado é: " + c);

}
}