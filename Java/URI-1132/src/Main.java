import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int x = sc.nextInt();
        int y = sc.nextInt();
        int soma = 0;
        
        int menor = x;
        int maior = y;
        
        if (x > y) {
            menor = y;
            maior = x;
        }
        
        for (int i = menor; i <= maior; i++) {
            if (i % 13 != 0) {
                soma = soma + i;
            }
        }
        System.out.println(soma);
        
        sc.close();
    }
    
}
