/* Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.
 * 
 * Entrada
 * A entrada será um valor inteiro positivo.
 * 
 * Saída
 * A saída será uma sequência de seis números ímpares.
 * 
 * Exemplo
 * ==============================================================
 * Entrada                              Saída
 * ==============================================================
 * 8                                    9
 *                                      11
 *                                      13
 *                                      15
 *                                      17
 *                                      19
 *                                      
 */

using System;

namespace URI_1070 {
    class Program {
        static void Main(string[] args) {

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 ==0) {
                numero++;
            }

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(numero);
                numero = numero + 2;
            }
        }
    }
}
