/* Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
 * 
 * Entrada
 * Não há nenhuma entrada neste problema.
 * 
 * Saída
 * Imprima a sequencia conforme exemplo abaixo.
 * 
 * Exemplo
 * =============================================================================
 * Entrada										Saída
 * =============================================================================
 * 												I=1 J=7
 * 												I=1 J=6
 * 												I=1 J=5
 * 												I=3 J=9
 * 												I=3 J=8
 * 												I=3 J=7
 * 												...
 * 												I=9 J=15
 * 												I=9 J=14
 * 												I=9 J=13
 * 
 */

public class Main {

	public static void main(String[] args) {
		
		int j = 7;
        for (int i = 1; i <= 9; i = i + 2)
        {
        	System.out.println("I=" + i + " J=" + j);
        	System.out.println("I=" + i + " J=" + (j - 1));
        	System.out.println("I=" + i + " J=" + (j - 2));
            j = j + 2;
        }

	}

}
