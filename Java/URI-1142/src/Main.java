import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
        int contador = 1;

        for (int i = 0; i < N; i++)
        {
        	System.out.print(contador + " ");
            contador += 1;
            System.out.print(contador + " ");
            contador += 1;
            System.out.println(contador + " PUM");
            contador += 2;
        }
        
        sc.close();
	}

}
