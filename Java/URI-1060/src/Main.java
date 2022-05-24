import java.util.Locale;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        int cont = 0;
        
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        double d = sc.nextDouble();
        double e = sc.nextDouble();
        double f = sc.nextDouble();
        
        if (a > 0) {
            cont++;
        } 
        
        if (b > 0) {
            cont++;
        } 
        
        if (c > 0) {
            cont++;
        } 
        
        if (d > 0) {
            cont++;
        } 
        
        if (e > 0) {
            cont++;
        } 
        
        if (f > 0) {
            cont++;
        }
        
        System.out.println(cont + " valores positivos");
        
        sc.close();
    }
}