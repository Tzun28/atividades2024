/*3. Faça um programa que calcule e mostre a área de um trapézio. Sabe-se que:
𝐴𝑟𝑒𝑎 = (𝑏𝑎𝑠𝑒 𝑚𝑎𝑖𝑜𝑟 + 𝑏𝑎𝑠𝑒 𝑚𝑒𝑛𝑜𝑟)/2 . 𝑎𝑙𝑡𝑢𝑟𝑎*/
class Questaotresum {

public static void Rodar(){
    Console.WriteLine("Digite a base maior");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a base menor");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura.");
    double c = double.Parse(Console.ReadLine());

    double d = ((a + b) / 2)  * c;
    Console.WriteLine("A área do trapézio é " + d);

}
}