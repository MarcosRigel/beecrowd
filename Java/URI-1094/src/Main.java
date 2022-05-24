import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n = sc.nextInt();

        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;

        for (int i = 0; i < n; i++)
        {
            int quantia = sc.nextInt();
            char tipo = sc.next().charAt(0);

            if (tipo == 'C')
            {
                coelhos = coelhos + quantia;
            }
            else if (tipo == 'R')
            {
                ratos = ratos + quantia;
            }
            else
            {
                sapos = sapos + quantia;
            }
        }

        int total = coelhos + ratos + sapos;
        double porcentagemCoelhos = (double)coelhos / total * 100.0;
        double porcentagemRatos = (double)ratos / total * 100.0;
        double porcentagemSapos = (double)sapos / total * 100.0;
        
        System.out.println("Total: " + total + " cobaias");
        System.out.println("Total de coelhos: " + coelhos);
        System.out.println("Total de ratos: " + ratos);
        System.out.println("Total de sapos: " + sapos);
        System.out.println("Percentual de coelhos: " + String.format("%.2f", ( (double) coelhos / total) * 100) + " %");
        System.out.println("Percentual de ratos: " + String.format("%.2f", ( (double) ratos / total) * 100) + " %");
        System.out.println("Percentual de sapos: " + String.format("%.2f", ( (double) sapos / total) * 100) + " %");
        
        sc.close();
	}

}
