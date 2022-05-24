/* Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, 
 * uma linha em branco e em seguida, os valores na sequência como foram lidos.
 * 
 * Entrada
 * A entrada contem três números inteiros.
 * 
 * Saída
 * Imprima a saída conforme foi especificado.
 * 
 * Exemplo
 * ========================================================
 * Entrada                              Saída
 * ========================================================
 * 7 21 -14                             -14
 *                                      7
 *                                      21
 *                                      
 *                                      7
 *                                      21
 *                                      -14
 * ========================================================
 * -14 21 7                             -14
 *                                      7
 *                                      21
 *                                      
 *                                      -14
 *                                      21
 *                                      7
 */

using System;

namespace URI_1042 {
    class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);

            if (a > b && a > c) {
                if (b > c) {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }

            if (a < b && a < c) {
                if (b > c) {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
                else {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
            }

            if (a > b && a < c) {
                if (b > c) {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
            }

            if (a < b && a > c) {
                if (b > c) {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
