/* Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível 
 * mostre a mensagem “divisao impossivel” para os valores em questão.
 * 
 * Entrada
 * A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.
 * 
 * Saída
 * Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível 
 * efetuar o cálculo.
 * 
 * Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)
 * 
 * Exemplo:
 * ===================================================================
 * Entrada                                          Saída
 * ===================================================================
 * 3                                                -1.5
 * 3 -2                                             divisao impossivel
 * -8 0                                             0.0
 * 0 8
 * 
 */

using System;
using System.Globalization;

namespace URI_1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int X = int.Parse(vetor[0]);
                int Y = int.Parse(vetor[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                } 
                else
                {
                    double divisao = (double) X / Y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
