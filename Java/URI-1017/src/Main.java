import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner (System.in);
		
		int x = sc.nextInt();
		int y = sc.nextInt();
		double result = x * y;
		
		double z = result / 12.0;
		
		System.out.printf("%.3f%n", z);
		
		sc.close();

	}

}
