/* Mariazinha quer resolver um problema interessante. Dadas as informações de população e a taxa de crescimento de duas cidades quaisquer (A e B),
 * ela gostaria de saber quantos anos levará para que a cidade menor (sempre é a cidade A) ultrapasse a cidade B em população. Claro que ela quer 
 * saber apenas para as cidades cuja taxa de crescimento da cidade A é maior do que a taxa de crescimento da cidade B, portanto, previamente já 
 * separou para você apenas os casos de teste que tem a taxa de crescimento maior para a cidade A. Sua tarefa é construir um programa que apresente 
 * o tempo em anos para cada caso de teste.
 * Porém, em alguns casos o tempo pode ser muito grande, e Mariazinha não se interessa em saber exatamente o tempo para estes casos. Basta que você 
 * informe, nesta situação, a mensagem "Mais de 1 seculo.".
 * 
 * Entrada
 * A primeira linha da entrada contém um único inteiro T, indicando o número de casos de teste (1 ≤ T ≤ 3000). Cada caso de teste contém 4 números: 
 * dois inteiros PA e PB (100 ≤ PA < 1000000, PA < PB ≤ 1000000) indicando respectivamente a população de A e B, e dois valores G1 e G2 (0.1 ≤ G1 ≤ 
 * 10.0, 0.0 ≤ G2 ≤ 10.0, G2 < G1) com um digito após o ponto decimal cada, indicando respectivamente o crescimento populacional de A e B (em percentual).
 * Atenção: A população é sempre um valor inteiro, portanto, um crescimento de 2.5 % sobre uma população de 100 pessoas resultará em 102 pessoas, e não 
 * 102.5 pessoas, enquanto um crescimento de 2.5% sobre uma população de 1000 pessoas resultará em 1025 pessoas. Além disso, não utilize variáveis de precisão 
 * simples para as taxas de crescimento.
 * 
 * Saída
 * Imprima, para cada caso de teste, quantos anos levará para que a cidade A ultrapasse a cidade B em número de habitantes. Obs.: se o tempo for mais do que 100
 * anos o programa deve apresentar a mensagem: Mais de 1 seculo. Neste caso, acredito que seja melhor interromper o programa imediatamente após passar de 100 anos,
 * caso contrário você poderá receber como resposta da submissão deste problema "Time Limit Exceeded".
 * 
 * Exemplo
 * ==============================================================
 * Entrada                                      Saída
 * ==============================================================
 * 6                                            51 anos.
 * 100 150 1.0 0                                16 anos.
 * 90000 120000 5.5 3.5                         12 anos.
 * 56700 72000 5.2 3.0                          Mais de 1 seculo.
 * 123 2000 3.0 2.0                             10 anos.
 * 100000 110000 1.5 0.5                        100 anos.
 * 62422 484317 3.1 1.0
 * 
 */

using System;
using System.Globalization;

namespace BEE_1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);
                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                while (pa <= pb && anos < 101)
                {
                    pa += (int)((pa * cpa) / 100);
                    pb += (int)((pb * cpb) / 100);
                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine(anos + " anos.");
                }
            }

        }
    }
}
