import java.util.Scanner;

public class Main {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int numero = 0;
        int contIn = 0;
        int contOut = 0;
        
        for (int i = 0; i < N; i++) {
            numero = sc.nextInt();
            if (numero >= 10 && numero <= 20) {
                contIn += 1;
            } else {
                contOut += 1;
            }
        }
        
        System.out.println(contIn + " in");
        System.out.println(contOut + " out");
        sc.close();
    }
}