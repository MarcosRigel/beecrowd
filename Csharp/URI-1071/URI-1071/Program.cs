/* Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros.
 * 
 * Saída
 * O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre 
 * os valores fornecidos na entrada que deverá caber em um inteiro.
 * 
 * Exemplo:
 * ===========================================================
 * Entrada                                  Saída
 * ===========================================================
 * 6                                        5
 * -5
 * ===========================================================
 * 15                                       13
 * 12
 * ===========================================================
 * 12                                       0
 * 12
 */

using System;

namespace URI_1071 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int menor = 0;
            int maior = 0;

            if (x > y) {
                maior = x;
                menor = y;
            } else {
                maior = y;
                menor = x;
            }

            int soma = 0;

            for (int i = menor + 1; i < maior; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}