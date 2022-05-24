/* Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.
 * 
 * Entrada
 * O arquivo de entrada contém 5 valores inteiros quaisquer.
 * 
 * Saída
 * Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.
 * 
 * Exemplo
 * =========================================================================
 * Entrada                                              Saída
 * =========================================================================
 * 7                                                    3 valores pares
 * -5
 * 6
 * -4
 * 12
 * 
 */

using System;

namespace URI_1065 {
    class Program {
        static void Main(string[] args) {

            int numero = 0;
            int pares = 0;

            for (int i = 0; i < 5; i++) {
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0) {
                    pares++;
                }
            }

            Console.WriteLine(pares + " valores pares");
        }
    }
}
