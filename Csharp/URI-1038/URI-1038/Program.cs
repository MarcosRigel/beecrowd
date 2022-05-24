/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
 * A seguir, calcule e mostre o valor da conta a pagar.
 * 
 * ======================================================
 * CODIGO           ESPECIFICAÇÃO               PREÇO
 * ======================================================
 * 1                Cachorro Quente             R$ 4.00
 * 2                X-Salada                    R$ 4.50
 * 3                X-Bacon                     R$ 5.00
 * 4                Torrada simples             R$ 2.00
 * 5                Refrigerante                R$ 1.50
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item 
 * conforme tabela acima.
 * 
 * Saída
 * O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após
 * o ponto decimal.
 * 
 * Exemplo:
 * ================================================================
 * Entrada                                          Saída
 * ================================================================
 * 3 2                                              Total: R$ 10.00
 * ================================================================
 * 4 3                                              Total: R$ 6.00
 * ================================================================
 * 2 3                                              Total: R$ 13.50
 * 
 */

using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vetor[0]);
            double quantidade = int.Parse(vetor[1]);

            if(codigo == 1) {
                quantidade *= 4;
            } else if(codigo == 2) {
                quantidade *= 4.50;
            } else if (codigo == 3) {
                quantidade *= 5.0;
            } else if (codigo == 4) {
                quantidade *= 2.00;
            } else if(codigo == 5) {
                quantidade *= 1.50;
            }

            Console.WriteLine("Total: R$ " + quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
