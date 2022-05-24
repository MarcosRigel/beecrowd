/* Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são 
 * múltiplos de 13 entre X e Y, incluindo ambos.
 * 
 * Entrada
 * O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.
 * 
 * Saída
 * Imprima a soma de todos os valores não divisíveis por 13 entre os dois valores lidos na entrada, 
 * inclusive ambos se for o caso.
 * 
 * Exemplo
 * ================================================================
 * Entrada                                      Saída
 * ================================================================
 * 100                                          13954
 * 200
 * 
 */

using System;

namespace URI_1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int menor = x;
            int maior = y;

            if (x > y)
            {
                menor = y;
                maior = x;
            }

            int soma = 0;
            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
