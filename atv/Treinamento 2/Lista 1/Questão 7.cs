/*
7. Fazer um programa que receba os três coeficientes de uma equação do segundo grau e calcule
as suas raízes. Suponha que só serão informadas equações com raízes reais
*/
class Questaoseteum {

public static void Rodar(){
    Console.WriteLine("Digite as duas notas");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = ((a * 2) + (b * 3)) / 5;
    Console.WriteLine("O resultado é: " + c);

}
}