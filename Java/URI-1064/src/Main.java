import java.util.Locale;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        int cont = 0;
        int cont2 = 0;
        double soma = 0.0;
        double media = 0.0;
        double a;
        
        while(cont < 6) {
            a = sc.nextDouble();
            if (a > 0) {
                soma = soma + a;
                cont2 = cont2 + 1;
            }
            cont = cont + 1;
        }
        
        media = soma / cont2;
        
        System.out.println(cont2 + " valores positivos");
        System.out.printf("%.1f%n", media);
        
        sc.close();
    }
    
}
