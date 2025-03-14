using System.Runtime.InteropServices.Marshalling;

class BackEnd {

public static void Calculadora() {
    Console.WriteLine("Escolha um tipo de operação");
        Console.WriteLine("1 - Soma"); Console.WriteLine("2 - Subtração"); Console.WriteLine("3 - Multiplicação"); Console.WriteLine("4 - Divisão");
    int operacoes = int.Parse(Console.ReadLine());
    if (operacoes >= 1 && operacoes <= 4) 
    {
        Console.WriteLine("Digite dois valores");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double y = 0;
        switch (operacoes) {
            case 1:
                double c = double.Parse(Console.ReadLine());
                y = BackEnd.Soma(a, b, c);
                break;
            case 2:
                y = BackEnd.Subtração(a, b);
                break;
            case 3:
                y = BackEnd.Multiplicação(a, b);
                break;
            case 4:
                y = BackEnd.Divisão(a, b);
                break;
            default: 
                break;
        }
        Console.WriteLine("O resultado final é: " + y);
    }
    else Console.WriteLine("Esse número não é válido"); 

}

/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

    public static double Soma(double a, double b, double c) {
                double y = a + b + c;
                return y;
    }

    public static double Subtração(double a, double b) {
        double y = a - b;
        return y;
    }

    public static double Multiplicação(double a, double b) {
        double y = a * b;
        return y;
    }

    public static double Divisão(double a, double b) {
        double y = a / b;
        return y;
    }
}