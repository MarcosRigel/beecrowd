import java.io.Console;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
        int primeiro = 0;
        int segundo = 0;
        int terceiro = 0;

        for (int i = 1; i <= N; i++)
        {
            primeiro = i;
            System.out.print(primeiro + " ");
            segundo = primeiro * primeiro;
            System.out.print(segundo + " ");
            terceiro = segundo * primeiro;
            System.out.println(terceiro);
        }
        
        sc.close();

	}

}
