/* Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). Para cada par lido, mostre a 
 * sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).
 * 
 * Entrada
 * O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.
 * 
 * Saída
 * Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.
 * 
 */

using System;

namespace BEE_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int m = int.Parse(vetor[0]);
            int n = int.Parse(vetor[1]);

            while(m != 0 && n !=0)
            {
                int somador = 0;
                if (m > n)
                {
                    while (m >= n)
                    {
                        Console.Write(n + " ");
                        somador += n;
                        n++;
                    }
                    Console.WriteLine("Sum=" + somador);
                }
                else
                {
                    while (n >= m)
                    {
                        Console.Write(m + " ");
                        somador += m;
                        m++;
                    }
                    Console.WriteLine("Sum=" + somador);
                }

                vetor = Console.ReadLine().Split(' ');
                m = int.Parse(vetor[0]);
                n = int.Parse(vetor[1]);
            }
        }
    }
}
