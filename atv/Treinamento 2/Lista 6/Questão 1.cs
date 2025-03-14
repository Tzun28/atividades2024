using System;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
/*
2. Faça um procedimento que preencha um vetor com as notas de uma turma de 10 alunos. Faça
um outro procedimento que receba um vetor preenchido com as notas, calcule a média da
turma e conte quantos alunos obtiveram nota acima da média. Esse procedimento deve exibir
a média e o resultado da contagem. Faça um programa que declare as devidas variáveis e
acione os procedimentos.*/
class Questaoumseis
{
    public static void Rodar()
    {
    Console.WriteLine("Digite a nota dos alunos");
        int[] Notas = new int [10];
        for (int i = 0; i < 10; i++){
        Notas[i] = int.Parse(Console.ReadLine());
    }
            Deltaro(Notas);
}
    public static void Deltaro(int[] Notas) {
        double delta = 0, contagem = 0;
        for (int i = 0; i < 10; i++) {
            int astro = Notas[i];
            delta += astro;
        }
        for (int i = 0; i < 10; i++) {
                    if (Notas[i] >= (delta/10)) contagem++;
        }
        Console.WriteLine($"A média de notas da turma é {delta/10}");
        Console.WriteLine($"O número de alunos que ficou acima da média é de {contagem}");
    }
}
