/* Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média 
 * de todos os valores positivos digitados, com um dígito após o ponto decimal.
 * 
 * Entrada
 * A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
 * 
 * Saída
 * O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.
 * 
 * Exemplo
 * ==================================================================
 * Entrada                                      Saída
 * ==================================================================
 * 7                                            4 valores positivos
 * -5                                           7.4
 * 6
 * -3.4
 * 4.6
 * 12
 */

using System;
using System.Globalization;

namespace URI_1064 {
    class Program {
        static void Main(string[] args) {

            double numero = 0;
            double positivo = 0;
            double soma = 0;

            for (int i = 0; i < 6; i++) {
                
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero > 0) {
                    positivo++;
                    soma = soma + numero;
                }
            }

            double media = soma / positivo;
            Console.WriteLine(positivo + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
