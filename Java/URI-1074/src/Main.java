import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int n = sc.nextInt();
		int cont = 0;
		
		while(n > cont) {
			int x = sc.nextInt();
			
			if(x == 0) {
				System.out.println("NULL");
			} else if(x > 0) {
				if(x % 2 == 0) {
				System.out.println("EVEN POSITIVE");
				}
				else {
					System.out.println("ODD POSITIVE");
				}
			}
			else {
				if(x % 2 == 0) {
					System.out.println("EVEN NEGATIVE");
				} else {
					System.out.println("ODD NEGATIVE");
				}
			}
			
			cont++;
		}
		
		sc.close();
	}

}
