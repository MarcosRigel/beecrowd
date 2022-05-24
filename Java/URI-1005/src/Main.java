import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double a = sc.nextDouble();
		double b = sc.nextDouble();
		double media = ((a * 3.5) + (b * 7.5)) / 11.0;
		
		System.out.printf("MEDIA = %.5f%n", media);
		
		sc.close();

	}

}
