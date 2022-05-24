/* Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, 
 * mostrando 4 casas decimais após a vírgula, segundo a fórmula:
 * Distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));
 * 
 * Entrada
 * O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.
 * 
 * Saída
 * Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
 * 
 * Exemplo
 * =======================================================================
 * Entrada                                          Saída
 * =======================================================================
 * 1.0 7.0                                          4.4721
 * 5.0 9.0
 * =======================================================================
 * -2.5 0.4                                         16.1484
 * 12.1 7.3
 * =======================================================================
 * 2.5 -0.4                                         16.4575
 * -12.2 7.0
 * 
 */

using System;
using System.Globalization;

namespace URI_1015 {
    class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            vetor = Console.ReadLine().Split(' ');
            double x2 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
