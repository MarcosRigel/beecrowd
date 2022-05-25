/* Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros.
 * 
 * Saída
 * O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre
 *  os valores fornecidos na entrada que deverá caber em um inteiro.
 * 
 * Exemplo
 * =============================================================================
 * Entrada								Saída
 * =============================================================================
 * 6									5
 * -5
 * =============================================================================
 * 15									13
 * 12
 * =============================================================================
 * 12									0
 * 12
 */

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
        
	       int x = sc.nextInt();
	       int y = sc.nextInt();
	       
	       int min, max;
	       if (x < y) {
	            min = x;
	            max = y;
	       } else {
	           min = y;
	           max = x;
	       }
	       
	       int soma = 0;
	       for (int i = min+1; i < max; i++) {
	            if (i % 2 != 0) {
	               soma = soma + i;
	           }
	       }
	       
	       System.out.println(soma);
	       
	       sc.close();
	}

}
