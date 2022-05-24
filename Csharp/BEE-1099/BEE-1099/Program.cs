/* Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. 
 * Você deve apresentar a soma de todos os ímpares existentes entre X e Y.
 * 
 * Entrada
 * A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma linha contendo dois 
 * inteiros X e Y.
 * 
 * Saída
 * Imprima a soma de todos valores ímpares entre X e Y.
 * 
 * Exemplo
 * ======================================================================
 * Entrada                                      Saída
 * ======================================================================
 * 7                                            0
 * 4 5                                          11
 * 13 10                                        5
 * 6 4                                          0
 * 3 3                                          0
 * 3 5                                          0
 * 3 4                                          12
 * 3 8
 */

using System;

namespace BEE_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int maior = 0;
            int menor = 0;

            for(int i=0; i<n; i++)
            {
                int contadorImpar = 0;
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

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

                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        contadorImpar += j;
                    }
                }
                Console.WriteLine(contadorImpar);

            }
        }
    }
}
