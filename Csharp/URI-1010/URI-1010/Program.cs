/* Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de
 * peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
 * 
 * Entrada
 * O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
 * 
 * Saída
 * A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser 
 * apresentado com 2 casas após o ponto.
 * 
 * Exemplo
 * =====================================================================================
 * Entrada                                                      Saída
 * =====================================================================================
 * 12 1 5.30                                                    VALOR A PAGAR: R$ 15.50
 * 16 2 5.10
 * =====================================================================================
 * 13 2 15.30                                                   VALOR A PAGAR: R$ 51.40
 * 161 4 5.20
 * =====================================================================================
 * 1 1 15.10                                                    VALOR A PAGAR: R$ 30.20
 * 2 1 15.10
 * 
 */

using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int peca1 = int.Parse(vetor[0]);
            int numeroPeca1 = int.Parse(vetor[1]);
            double valorUnitario1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double result1 = valorUnitario1 * numeroPeca1;

            vetor = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(vetor[0]);
            int numeroPeca2 = int.Parse(vetor[1]);
            double valorUnitario2 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double result2 = valorUnitario2 * numeroPeca2;

            double valorPagar = result1 + result2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
