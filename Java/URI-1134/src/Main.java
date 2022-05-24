import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int x = sc.nextInt();
        int contadorAlcool = 0;
        int contadorGasolina = 0;
        int contadorDiesel = 0;
        
        do {
            if (x == 1) {
              contadorAlcool = contadorAlcool + 1;
            }
            else if (x == 2) {
                contadorGasolina = contadorGasolina + 1;
            }
            else if (x == 3) {
                contadorDiesel = contadorDiesel + 1;
            }
            x = sc.nextInt();
        } while(x != 4);
        
        System.out.println("MUITO OBRIGADO");
        System.out.println("Alcool: " + contadorAlcool);
        System.out.println("Gasolina: " + contadorGasolina);
        System.out.println("Diesel: " + contadorDiesel);
        
        sc.close();        
    }
}