/* Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os
 * experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias foram
 * utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.
 * 
 * Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações,
 * ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de 
 * cobaias utilizadas em cada experimento.
 * 
 * Entrada
 * A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. 
 * Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas 
 * e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).
 * 
 * Saída
 * Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em 
 * relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto.
 * 
 * Exemplo
 * ===================================================================
 * Entrada                              Saída
 * ===================================================================
 * 10                                   Total: 92 cobaias
 * 10 C                                 Total de coelhos: 29
 * 6 R                                  Total de ratos: 40
 * 15 S                                 Total de sapos: 23
 * 5 C                                  Percentual de coelhos: 31.52 %
 * 14 R                                 Percentual de ratos: 43.48 %
 * 9 C                                  Percentual de sapos: 25.00 %
 * 6 R
 * 8 S
 * 5 C
 * 14 R
 */

using System;

namespace URI_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                int quantia = int.Parse(valores[0]);
                char tipo = char.Parse(valores[1]);

                if (tipo == 'C')
                {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == 'R')
                {
                    ratos = ratos + quantia;
                }
                else
                {
                    sapos = sapos + quantia;
                }
            }

            int total = coelhos + ratos + sapos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100.0;
            double porcentagemSapos = (double)sapos / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");
        }
    }
}
