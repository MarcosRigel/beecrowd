import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int a = sc.nextInt();
		int b = sc.nextInt();
		double x = 0;
		
		if(a == 1) {
			x = 2.0;
		} 
		if (a == 2) {
			x = 4.50; 
		} 
		if (a == 3) {
			x = 5.00;
		} 
		if(a == 4) {
			x = 2.00;
		} 
		if(a == 5) {
			x = 1.50;
		}

		double result = x * b;
		System.out.printf("Total: R$ %.2f%n", result);
		
		sc.close();
	}

}
