/* Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
 * 
 * Entrada
 * O arquivo de entrada contém um número inteiro positivo N.
 * 
 * Saída
 * Imprima a saída conforme o exemplo fornecido.
 * 
 * Exemplo
 * ===========================================================
 * Entrada                                  Saída
 * ===========================================================
 * 5                                        1 1 1
 *                                          2 4 8
 *                                          3 9 27
 *                                          4 16 64
 *                                          5 25 125
 *                                          
 */

using System;

namespace URI_1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int primeiro = 0;
            int segundo = 0;
            int terceiro = 0;

            for (int i = 1; i <= N; i++)
            {
                primeiro = i;
                Console.Write(primeiro + " ");
                segundo = primeiro * primeiro;
                Console.Write(segundo + " ");
                terceiro = segundo * primeiro;
                Console.WriteLine(terceiro);
            }
        }
    }
}
