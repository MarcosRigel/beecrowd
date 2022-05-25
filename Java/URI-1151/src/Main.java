/* A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci. Nessa sequência, cada número, depois dos 2 primeiros, é igual à soma dos 2 anteriores. 
 * Escreva um algoritmo que leia um inteiro N (N < 46) e mostre os N primeiros números dessa série.
 * 
 * Entrada
 * O arquivo de entrada contém um valor inteiro N (0 < N < 46).
 * 
 * Saída
 * Os valores devem ser mostrados na mesma linha, separados por um espaço em branco. Não deve haver espaço após o último valor.
 * 
 * Exemplo
 * =============================================================================
 * Entrada													Saída
 * =============================================================================
 * 5														0 1 1 2 3
 * 
 */

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();
        int Fn = 0;
        int fn = 1;

        for (int i = 0; i < N; i++) {
            if (i == N - 1) {
            	System.out.println(Fn);
            }
            else {
            	System.out.println(Fn + " ");
            }
            int aux = fn;
            fn = Fn;
            Fn = aux + fn;
        }
	}

}
