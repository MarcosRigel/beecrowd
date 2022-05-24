import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int x = sc.nextInt();
		
		for(int i = 1; i < x; i = i + 2) {
			System.out.println(i);	
		}
		
		if(x % 2 == 1) {
			System.out.println(x);
		}
		
		sc.close();
	}

}
