/* Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não 
 * entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.
 * 
 * Entrada
 * A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.
 * 
 * Saída
 * A saída contém um valor correspondente à média de idade dos indivíduos. A média deve ser impressa com dois dígitos após o ponto 
 * decimal.
 * 
 * Exemplo:
 * ===================================================
 * Entrada                          Saída
 * ===================================================
 * 34                               39.25
 * 56
 * 44
 * 23
 * -2
 * 
 */

using System;
using System.Globalization;

namespace URI_1154 {
    class Program {
        static void Main(string[] args) {

            int idade = int.Parse(Console.ReadLine());
            int contador = 0;
            int soma = 0;

            while(idade > 0) {
                contador++;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }

            double media = (double) soma / contador;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
