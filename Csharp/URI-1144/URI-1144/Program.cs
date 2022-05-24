/* Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa,
 * seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.
 * 
 * Entrada
 * O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).
 * 
 * Saída
 * Imprima a saída conforme o exemplo fornecido.
 * 
 * Exemplo
 * =============================================================
 * Entrada                                  Saída
 * =============================================================
 * 5                                        1 1 1
 *                                          1 2 2
 *                                          2 4 8
 *                                          2 5 9
 *                                          3 9 27
 *                                          3 10 28
 *                                          4 16 64
 *                                          4 17 65
 *                                          5 25 125
 *                                          5 26 126
 *                                          
 * 
 */

using System;

namespace URI_1144 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine(i + " " + segundo + " " + terceiro);
                Console.WriteLine(i + " " + (segundo + 1) + " " + (terceiro + 1));
            }
        }
    }
}
