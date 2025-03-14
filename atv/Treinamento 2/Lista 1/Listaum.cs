using System.Collections;
using System.ComponentModel;

class Listaum {
    public static void Funciona() {
        Console.WriteLine("Qual questão você deseja fazer?");
        int questão = int.Parse(Console.ReadLine());
        switch (questão){
            case 1:
                Questaoumum.Rodar();
                break;
            case 2:
                Questaodoisum.Rodar();
                break;
            case 3:
                Questaotresum.Rodar();
                break;
            case 4:
                Questaoquatroum.Rodar();
                break;
            case 5:
                Questaocincoum.Rodar();
                break;
            case 6:
                Questaoseisum.Rodar();
                break;
            case 7:
                Questaoseteum.Rodar();
                 break;
            case 8:
                Questaooitoum.Rodar();
                break;
            case 9:
                Questaonoveum.Rodar();
                break;
            case 10:
                Questaodezum.Rodar();
                break;
            default:
                Console.WriteLine("Essa questão não existe");
                break;
        }    
    }


}