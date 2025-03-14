class Roleplaytotal {
    public static int brincatheir (ref int num1, ref int num2) {
Console.WriteLine("Digite um número:");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número:");
num2 = int.Parse(Console.ReadLine());
return (num1 + num2);
}
public static void Roleplayzada ()
{
int val1=0, val2=0;
Console.WriteLine("A soma {0} é resultado de {1} com {2}", brincatheir(ref val1, ref val2), val1, val2);
}
}