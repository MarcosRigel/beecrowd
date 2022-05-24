/* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, 
 * cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor
 * tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
 * 
 * Entrada
 * O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.
 * 
 * Saída
 * Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
 * 
 * Exemplo
 * =========================================================================
 * Entrada                                              Saída
 * =========================================================================
 * 3                                                    5.7
 * 6.5 4.3 6.2                                          6.3
 * 5.1 4.2 8.1                                          9.3
 * 8.0 9.0 10.0
 * 
 */

using System;
using System.Globalization;

namespace URI_1079 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            string[] vetor;

            for (int i = 0; i < N; i++) {
                vetor = Console.ReadLine().Split(' ');
                double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                double media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0;

                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
