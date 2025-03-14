using System.Collections;
using System.ComponentModel;

class Listaseis {
    public static void Funciona() {
        Console.WriteLine("Qual questão você deseja fazer?");
        int questão = int.Parse(Console.ReadLine());
        switch (questão){
            case 1:
                Questaoumseis.Rodar();
                break;
            case 2:
                Questaodoisseis.Rodar();
                break;
            case 3:
                Questaotresseis.Rodar();
                break;
            case 4:
                Questaoquatroseis.Rodar();
                break;
            case 5:
                Questaocincoseis.Rodar();
                break;
            case 6:
                Questaoseisseis.Rodar();
                break;
            case 7:
                Questaoseteseis.Rodar();
                 break;
            case 8:
                Questaooitoseis.Rodar();
                break;
            case 9:
                Questaonoveseis.Rodar();
                break;
            case 10:
                Questaodezseis.Rodar();
                break;
            default:
                Console.WriteLine("Essa questão não existe");
                break;
        }    
    }


}

/*Escreva um procedimento que preencha um vetor de 15 números inteiros. Depois, crie uma
função que retorne um novo vetor apenas com os números que estão armazenados nas
posições pares do vetor gerado pelo procedimento.
2. Faça um procedimento que preencha um vetor com as notas de uma turma de 10 alunos. Faça
um outro procedimento que receba um vetor preenchido com as notas, calcule a média da
turma e conte quantos alunos obtiveram nota acima da média. Esse procedimento deve exibir
a média e o resultado da contagem. Faça um programa que declare as devidas variáveis e
acione os procedimentos.
3. Faça um procedimento que preencha um vetor de N elementos, conforme entrada de dados.
Depois, crie uma função que retorne a posição do menor elemento deste vetor.
4. Faça um procedimento que preencha 2 vetores X e Y com 10 elementos cada um (ocupando
as posições de 0 a 9 em cada vetor). Faça um outro procedimento que receba dois vetores
preenchidos e gera um novo vetor com os elementos desses 2 vetores intercalados de tal
forma que nas posições ímpares do novo vetor estejam os elementos do primeiro vetor e nas
posições pares os elementos do segundo vetor recebido por parâmetro. Faça um
procedimento que receba e exiba o conteúdo de um vetor. Faça um programa que faça as
devidas declarações e acione os módulos para exemplificar o seu uso.
5. Faça uma função que sorteie 5 números (entre 10 e 30) e retorne em um vetor. Depois crie
um procedimento que leia as tentativas do usuário para acertar um destes números. O
programa só deve parar quando o usuário acertar um número sorteado.
6. Em uma cidade, sabe-se hipoteticamente que, em outubro de 2024, não ocorreu temperatura
inferior a 15°C, nem superior a 40°C. Faça um programa que armazene as temperaturas de
cada dia de outubro em um vetor (de 31 posições), calcule e imprima:
a) A menor e a maior temperatura ocorrida;
b) A temperatura média;
c) O número de dias nos quais a temperatura foi inferior à temperatura média.
7. Desenvolva um procedimento que preencha uma matriz 3x3 com números aleatórios de 1 a
30. Depois, crie uma função que encontre, mostre todos os números primos presentes na
matriz e retorne a soma das posições desses números primos.
8. Faça um procedimento que preencha uma matriz M 5 x 5. Faça uma função que receba
uma matriz preenchida, calcule e retorne cada uma das somas a seguir (uma função para
cada item abaixo):
a) da linha 3 de M
b) da coluna 2 de M
c) da diagonal principal
d) da diagonal secundária
e) de todos os elementos da matriz.
Faça um programa que faça as devidas declarações e acione os módulos para exemplificar
o seu uso.
9. Dada a matriz A, a matriz transposta de A, representada por AT, terá em sua primeira
coluna a primeira linha da matriz A; já a segunda coluna da matriz transposta será a
segunda linha da matriz A, e assim sucessivamente. Veja o exemplo abaixo:
Diante disso, crie uma função que receba uma matriz e retorne a sua transposta.
10. Escrever um procedimento que preencha uma matriz M(10,10) e a escreva. Faça outros
procedimentos que recebam uma matriz preenchida, realize as trocas indicadas a seguir
(um procedimento para cada uma delas) e exiba a matriz resultante da troca:
a) a linha 2 com a linha 8
b) a coluna 4 com a coluna 10
c) a diagonal principal com a diagonal secundária
Faça um programa que faça as devidas declarações e acione os módulos para exemplificar
o seu uso.
*/