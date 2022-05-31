import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int desejada = sc.nextInt();
		int real = sc.nextInt();
		int result = desejada - real;
		
		System.out.println(result);
		
		sc.close();
	}

}
