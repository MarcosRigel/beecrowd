import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int peca1 = sc.nextInt();
		int numeroPeca1 = sc.nextInt();
		double valorUnitario1 = sc.nextDouble();
		int peca2 = sc.nextInt();
		int numeroPeca2 = sc.nextInt();
		double valorUnitario2 = sc.nextDouble();
		
		double valorPagar = ((valorUnitario1 * numeroPeca1) + (valorUnitario2 * numeroPeca2));
		
		System.out.printf("VALOR A PAGAR: R$ %.2f%n", valorPagar);
		
		sc.close();
	}

}
