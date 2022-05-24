import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);

		int m = sc.nextInt();
		int n = sc.nextInt();
		
		while (m > 0 && n > 0) {

			int menor = m;
			int maior = n;
			
			if (m > n) {
				menor = n;
				maior = m;
			}
			
			int soma = 0;
			for (int i=menor; i<=maior; i++) {
				soma = soma + i;
				System.out.print(i + " ");
			}
			System.out.println("Sum=" + soma);
			
			m = sc.nextInt();
			n = sc.nextInt();
		}
		
		sc.close();
	}

}
