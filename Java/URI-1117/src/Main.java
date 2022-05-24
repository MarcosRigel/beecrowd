import java.util.Locale;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        double x, y, media;
        
        x = sc.nextDouble();
        while(x < 0 || x > 10) {
            System.out.println("nota invalida");
            x = sc.nextDouble();
        }
        
        y = sc.nextDouble();
        while(y < 0 || y > 10) {
            System.out.println("nota invalida");
            y = sc.nextDouble();
        }
        
        media = (x + y) / 2.0; 
        
        System.out.printf("media = %.2f%n", media);
        
        sc.close();
    }   
}