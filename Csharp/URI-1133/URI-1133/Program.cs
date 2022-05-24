/* Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da 
 * divisão dele por 5 for igual a 2 ou igual a 3.
 * 
 * Entrada
 * O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.
 * 
 * Saída
 * Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.
 * 
 * Exemplo
 * ==================================================================
 * Entrada                                          Saída
 * ==================================================================
 * 10                                               12
 * 18                                               13
 *                                                  17
 */

using System;

namespace URI_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maior = 0;
            int menor = 0;

            if (x > y)
            {
                maior = x;
                menor = y;
            } 
            else
            {
                maior = y;
                menor = x;
            }


            for (int i = menor + 1; i < maior; i++)
            {
                menor += 1;
                if (menor % 5 == 2 || menor % 5 == 3)
                {
                    Console.WriteLine(menor);
                }
            }

        }
    }
}
