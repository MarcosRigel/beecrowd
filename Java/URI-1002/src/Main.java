import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double area, raio, pi;
		
		raio = sc.nextDouble();
		pi = 3.14159;
		area = pi * (raio * raio);
		
		System.out.printf("A=%.4f%n", area);
		
		sc.close();

	}

}
