/* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
 * 
 * Entrada
 * A entrada contém um valor inteiro N (0 < N < 13).
 * 
 * Saída
 * A saída contém um valor inteiro, correspondente ao fatorial de N.
 * 
 * Exemplo
 * ===================================================================
 * Entrada                                          Saída
 * ===================================================================
 * 4                                                24
 * 
 */

using System;

namespace URI_1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= N; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
