import java.util.Scanner;

public class Main {
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int x = sc.nextInt();
        int soma = 0;
        int contador1, contador2, contador3, contador4, contador5;
        
        while(x != 0) {
            
            if (x % 2 == 0) {
                contador1 = x + 2;
                contador2 = contador1 + 2;
                contador3 = contador2 + 2;
                contador4 = contador3 + 2;
                contador5 = x + contador1 + contador2 + contador3 + contador4;
                System.out.println(contador5);
            } 
            else {
                x = x + 1;
                contador1 = x + 2;
                contador2 = contador1 + 2;
                contador3 = contador2 + 2;
                contador4 = contador3 + 2;
                contador5 = x + contador1 + contador2 + contador3 + contador4;
                System.out.println(contador5);
            }
            
            x = sc.nextInt();
        }
        sc.close();
    }
}