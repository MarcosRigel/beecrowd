import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
        int numero = sc.nextInt();

        for (int i = 0; i < numero; i++) {
           int n = sc.nextInt();
           int n2 = sc.nextInt();
            System.out.println(n+n2);
        }
	}
}
