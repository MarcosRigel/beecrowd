/* Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo. Por exemplo, o número 7 é primo, pois pode ser 
 * dividido apenas pelo número 1 e pelo número 7.
 * 
 * Entrada
 * A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100), indicando o número de casos de teste da 
 * entrada. Cada uma das N linhas seguintes contém um valor inteiro X (1 < X ≤ 107), que pode ser ou não, um número primo.
 * 
 * Saída
 * Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”, de acordo com a especificação fornecida.
 * 
 * Exemplo
 * ============================================================
 * Entrada                                  Saída
 * ============================================================
 * 3                                        8 nao eh primo
 * 8                                        51 nao eh primo
 * 51                                       7 eh primo
 * 7
 */

using System;

namespace BEE_1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int metade = x / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++)
                {
                    if (x % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    Console.WriteLine(x + " nao eh primo");
                }
            }
        }
    }
}
