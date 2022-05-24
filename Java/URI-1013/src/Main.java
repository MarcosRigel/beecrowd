import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int a = sc.nextInt();
		int b = sc.nextInt();
		int c = sc.nextInt();
		
		int maiorab = (a + b + Math.abs(a - b)) / 2;
		int maiorc = (maiorab + c + Math.abs(maiorab - c)) / 2;
		
		System.out.println(maiorc + " eh o maior");
		
		sc.close();
	}

}
