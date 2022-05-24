import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();
		
		int ano = N / 365;
        N = N % 365;
        int mes = N / 30;
        N = N % 30;
        int dia = N;

        System.out.println(ano + " ano(s)");
		System.out.println(mes + " mes(es)");
        System.out.println(dia + " dia(s)");
        
		sc.close();
	}

}
