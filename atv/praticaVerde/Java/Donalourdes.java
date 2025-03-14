import java.util.Scanner;

public class Donalourdes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double r = 0, n = 0, s = 998;
        
        while (r != 999) {
            r = scanner.nextDouble();
            if (r > n && r != 999) n = r;
            if (r < s) s = r;
        }
        
        System.out.printf("%.2f %.2f\n", n, s);
        scanner.close();
    }
}
