/* Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As 
 * notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
 * 
 * Entrada
 * O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
 * 
 * Saída
 * Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não 
 * esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
 * 
 * Exemplo
 * ===========================================================================================================
 * Entrada                                                                      Saída
 * ===========================================================================================================
 * 576                                                                          576
 *                                                                              5 nota(s) de R$ 100,00
 *                                                                              1 nota(s) de R$ 50,00
 *                                                                              1 nota(s) de R$ 20,00
 *                                                                              0 nota(s) de R$ 10,00
 *                                                                              1 nota(s) de R$ 5,00
 *                                                                              0 nota(s) de R$ 2,00
 *                                                                              1 nota(s) de R$ 1,00
 * ===========================================================================================================
 * 11257                                                                        11257
 *                                                                              112 nota(s) de R$ 100,00
 *                                                                              1 nota(s) de R$ 50,00
 *                                                                              0 nota(s) de R$ 20,00
 *                                                                              0 nota(s) de R$ 10,00
 *                                                                              1 nota(s) de R$ 5,00
 *                                                                              1 nota(s) de R$ 2,00
 *                                                                              0 nota(s) de R$ 1,00
 * ===========================================================================================================
 * 503                                                                          503
 *                                                                              5 nota(s) de R$ 100,00
 *                                                                              0 nota(s) de R$ 50,00
 *                                                                              0 nota(s) de R$ 20,00
 *                                                                              0 nota(s) de R$ 10,00
 *                                                                              0 nota(s) de R$ 5,00
 *                                                                              1 nota(s) de R$ 2,00
 *                                                                              1 nota(s) de R$ 1,00
 */


using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(N);

            Console.WriteLine(N / 100 + " nota(s) de R$ 100,00");
            N = N % 100;
            Console.WriteLine(N / 50 + " nota(s) de R$ 50,00");
            N = N % 50;
            Console.WriteLine(N / 20 + " nota(s) de R$ 20,00");
            N = N % 20;
            Console.WriteLine(N / 10 + " nota(s) de R$ 10,00");
            N = N % 10;
            Console.WriteLine(N / 5 + " nota(s) de R$ 5,00");
            N = N % 5;
            Console.WriteLine(N / 2 + " nota(s) de R$ 2,00");
            N = N % 2;
            Console.WriteLine(N / 1 + " nota(s) de R$ 1,00");
        }
    }
}
