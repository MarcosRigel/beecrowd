/* Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 
 * Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
 * 
 * Perimetro = XX.X
 * Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
 * Area = XX.X
 * 
 * Entrada
 * A entrada contém três valores reais.
 * 
 * Saída
 * O resultado deve ser apresentado com uma casa decimal.
 * 
 * Exemplo
 * ======================================================================================
 * Entrada                                                              Saída
 * ======================================================================================
 * 6.0 4.0 2.0                                                          Area = 10.0
 * ======================================================================================
 * 6.0 4.0 2.1                                                          Perimetro = 12.1
 */

using System;
using System.Globalization;

namespace URI_1043 {
    class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            double A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double perimetro = 0.0;
            double area = 0.0;

            if (A < B + C && B < A + C && C < B + A) {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            } else {
                area = (A + B) * C / 2.0;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
