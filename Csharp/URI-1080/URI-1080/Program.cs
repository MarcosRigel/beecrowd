/* Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
 * 
 * Entrada
 * O arquivo de entrada contém 100 números inteiros, positivos e distintos.
 * 
 * Saída
 * Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
 * 
 * Exemplo
 * ==============================================================
 * Entrada                                      Saída
 * ==============================================================
 * 2                                            34565
 * 113                                          4
 * 45
 * 34565
 * 6
 * ...
 * 8
 * 
 */

using System;

namespace URI_1080 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int posicao = 1;

            for (int i = 2; i <= 100; i++) {
                
                int valores = int.Parse(Console.ReadLine());
                
                if (valores > N) {
                    N = valores;
                    posicao = i;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(posicao);
        }
    }
}
