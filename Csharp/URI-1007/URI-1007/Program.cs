/* Leia quatro valores inteiros A,B,C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA=(A*B-C*D).
 * 
 * Entrada
 * O arquivo de entrada contém 4 valores inteiros.
 * 
 * Saída
 * Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
 * 
 * Exemplo
 * ===========================================================================================
 * Entrada                                                              Saída
 * ===========================================================================================
 * 5                                                                    DIFERENCA = -26
 * 6
 * 7
 * 8
 * ===========================================================================================
 * 0                                                                    DIFERENCA = -56
 * 0
 * 7
 * 8
 * ===========================================================================================
 * 5                                                                    DIFERENCA = 86
 * 6
 * -7
 * 8
 * 
 */

using System;

namespace URI_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
