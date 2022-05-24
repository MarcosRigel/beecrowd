/* Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
 * 
 * S = 1 + 1/2 + 1/3 + … + 1/100
 * 
 * Entrada
 * Não há nenhuma entrada neste problema.
 * 
 * Saída
 * A saída contém um valor correspondente ao valor de S.
 * O valor deve ser impresso com dois dígitos após o ponto decimal.
 * 
 */

using System;
using System.Globalization;

namespace URI_1155 {
    class Program {
        static void Main(string[] args) {

            double a, b = 1, c, S = 0;

            for (a = 1; a <= 100; a++) {
                c = 1 / a;
                S += c;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
