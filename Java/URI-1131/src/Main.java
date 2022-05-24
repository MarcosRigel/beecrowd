import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int vitoriaInter = 0;
        int vitoriaGremio = 0;
        int inter, gremio;
        int opcao, totalGrenais = 0;
        int empates = 0;
        
        do {
            inter = sc.nextInt();
            gremio = sc.nextInt();
            
            if (inter > gremio) {
                vitoriaInter = vitoriaInter + 1;
            } 
            else if(gremio > inter) {
                vitoriaGremio = vitoriaGremio + 1;
            }
            else {
                empates = empates + 1;
            }
        
            System.out.println("Novo grenal (1-sim 2-nao)");
            opcao = sc.nextInt();
            
            while(opcao != 1 && opcao != 2) {
                System.out.println("Novo grenal (1-sim 2-nao)");
                opcao = sc.nextInt();
            }
            
            totalGrenais = totalGrenais + 1;
            
        } while(opcao != 2);
        
        System.out.println(totalGrenais + " grenais");
        System.out.println("Inter:" + vitoriaInter);
        System.out.println("Gremio:" + vitoriaGremio);
        System.out.println("Empates:" + empates);
        
        if (vitoriaInter > vitoriaGremio) {
            System.out.println("Inter venceu mais");
        } 
        else {
            System.out.println("Gremio venceu mais");
        }
        
        sc.close();
    }    
}