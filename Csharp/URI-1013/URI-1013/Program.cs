/* Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”.
 * Utilize a fórmula:
 *
 * MaiorAB = (a + b + abs(a-b)) / 2
 * 
 * Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para 
 * chegar no resultado esperado.
 * 
 * Entrada
 * O arquivo de entrada contém três valores inteiros.
 * 
 * Saída
 * Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
 * 
 * Exemplo
 * ===================================================
 * Entrada                              Saída
 * ===================================================
 * 7 14 106                             106 eh o maior
 * ===================================================
 * 217 14 6                             217 eh o maior
 * 
 */


using System;

namespace URI_1013 {
    class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maior = (c + maiorAB + Math.Abs(c - maiorAB)) / 2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}
