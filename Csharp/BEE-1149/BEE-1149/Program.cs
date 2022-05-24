/* Faça um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1). 
 * Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.
 * 
 * Entrada
 * A entrada contém somente valores inteiros, podendo ser positivos ou negativos. Todos os valores estão na mesma linha.
 * 
 * Saída
 * A saída contém apenas um valor inteiro.
 * 
 * Exemplo
 * ===========================================================
 * Entrada                                      Saída
 * ===========================================================
 * 3 2                                          7
 * ===========================================================
 * 3 -1 0 -2 2                                  7
 */

using System;

namespace BEE_1149
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int a, n, soma, i = 1;

            a = int.Parse(vetor[0]);
            n = int.Parse(vetor[i]);
            
            while (n <= 0)
            {
                i += 1;
                n = int.Parse(vetor[i]);
            }

            soma = 0;
            for (i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);
        }
    }
}
