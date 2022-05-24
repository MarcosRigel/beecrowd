import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);

		int x = sc.nextInt();
		int distancia = x * 2;

		System.out.println(distancia + " minutos");

		sc.close();
	}

}
