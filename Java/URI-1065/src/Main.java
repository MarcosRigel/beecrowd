import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int cont = 0;
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int d = sc.nextInt();
        int e = sc.nextInt();
        
        if (a % 2 == 0) {
            cont++;
        }
        
        if (b % 2 == 0) {
            cont++;
        }
        
        if (c % 2 == 0) {
            cont++;
        }
        
        if (d % 2 == 0) {
            cont++;
        }
        
        if (e % 2 == 0) {
            cont++;
        }
        
        System.out.println(cont + " valores pares");
        
        sc.close();
    }
    
}
