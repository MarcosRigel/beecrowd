import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int cont = 1;
        int x = sc.nextInt();
        
        if (x % 2 != 0) {
            System.out.println(x);
            while(cont < 6) {
                x = x + 2;
                System.out.println(x);
                cont++;
            }
        } 
        
        if(x % 2 == 0){
            x++;
            while(cont <= 6) {
                System.out.println(x);
                x = x + 2;
                cont++;
            }
        }
        
        sc.close();
    }
    
}
