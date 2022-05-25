/* Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.
 * 
 * Entrada
 * O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.
 * 
 * Saída
 * Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.
 * 
 * Exemplo
 * =============================================================================
 * Entrada									Saída
 * =============================================================================
 * 10										12
 * 18										13
 * 											17
 */

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int x = sc.nextInt();
		int y = sc.nextInt();
		
        int maior = 0;
        int menor = 0;

        if (x > y)
        {
            maior = x;
            menor = y;
        } 
        else
        {
            maior = y;
            menor = x;
        }


        for (int i = menor + 1; i < maior; i++)
        {
            menor += 1;
            if (menor % 5 == 2 || menor % 5 == 3)
            {
            	System.out.println(menor);
            }
        }

	}

}
