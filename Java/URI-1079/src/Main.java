import java.util.Locale;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int cont = 0;
        double a,b,c, soma;
        
        while(N > cont) {
            for (int i = 0; i < N; i++) {
                a = sc.nextDouble();
                b = sc.nextDouble();
                c = sc.nextDouble();
                soma = ((a*2.0) + (b * 3.0) +(c*5.0)) / 10.0;
                System.out.printf("%.1f%n", soma);
                cont++;
            }
        }
        
        sc.close();
    }
}