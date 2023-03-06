package application;

import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();
        int Fn = 0;
        int fn = 1;

        for (int i = 0; i < N; i++)
        {
            if (i == N - 1)
            {
            	System.out.print(Fn + " ");
            }
            else
            {
            	System.out.print(Fn + " ");
            }
            int aux = fn;
            fn = Fn;
            Fn = aux + fn;
        }
		
		sc.close();
		
	}

}
