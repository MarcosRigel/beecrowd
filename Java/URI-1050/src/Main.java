import java.util.Scanner;

public class Main {
    
    public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);
       
        int a = sc.nextInt();
       
        if (a == 61) {
            System.out.println("Brasilia");
        } 
        else if(a == 71) {
            System.out.println("Salvador");
        }
        else if (a == 11) {
            System.out.println("Sao Paulo");
        }
        else if (a == 21) {
            System.out.println("Rio de Janeiro");
        }
        else if (a == 32) {
            System.out.println("Juiz de Fora");
        }
        else if (a == 19) {
            System.out.println("Campinas");
        }
        else if (a == 27) {
            System.out.println("Vitoria");
        }
        else if (a == 31) {
            System.out.println("Belo Horizonte");
        }
        else{
            System.out.println("DDD nao cadastrado");
        }
       
       sc.close();
    }    
}