/*Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
 * S = 1 + 3/2 + 5/4 + 7/8 + ... + 39/?
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

namespace URI_1156
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerador;
            double denominador = 1.0, soma = 0.0;
            for (numerador = 1; numerador <= 39; numerador += 2)
            {
                soma = soma + numerador / denominador;
                denominador = denominador * 2.0;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
