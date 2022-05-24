import java.util.Scanner;

public class URI1080 {

    public static void main(String[] args) {
       
        Scanner sc = new Scanner(System.in);
        
        int maior, posicao;
        
        maior = sc.nextInt();
        posicao = 1;
        
        for(int i=2;i<=100;i++) {
            int numero = sc.nextInt();
            if(numero > maior) {
                maior = numero;
                posicao = i;
            }
        }
        
        System.out.println(maior);
        System.out.println(posicao);
        
        sc.close();
    }
}