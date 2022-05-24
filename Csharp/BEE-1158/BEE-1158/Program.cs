/* Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar
 * a soma de Y ímpares consecutivos a partir de X inclusive o próprio X se ele for ímpar. Por exemplo: para a entrada 4 5, a saída deve ser 45, que é 
 * equivalente à: 5 + 7 + 9 + 11 + 13 para a entrada 7 4, a saída deve ser 40, que é equivalente à: 7 + 9 + 11 + 13
 * 
 * Entrada
 * A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma linha contendo 
 * dois inteiros X e Y.
 * 
 * Saída
 * Imprima a soma dos consecutivos números ímpares a partir do valor X.
 * 
 * Exemplo
 * =============================================
 * Entrada                          Saída
 * =============================================
 * 2                                21
 * 4 3                              24
 * 11 2
 */

using System;

namespace BEE_1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int x = int.Parse(vetor[0]);
                int y = int.Parse(vetor[1]);
                int contador = 0;
                int contadorImpar = 0;

                while(contador < y)
                {
                    if (x % 2 != 0)
                    {
                        contadorImpar += x;
                        contador += 1;
                    }
                    x++;
                }

                Console.WriteLine(contadorImpar);
            }
        }
    }
}
