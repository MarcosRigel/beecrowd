/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos",
 * indicando se os valores lidos são múltiplos entre si.
 * 
 * Entrada
 * A entrada contém valores inteiros.
 * 
 * Saída
 * A saída deve conter uma das mensagens conforme descrito acima.
 * 
 * Exemplo
 * ==================================================================
 * Entrada                                          Saída
 * ==================================================================
 * 6 24                                             Sao Multiplos
 * ==================================================================
 * 6 25                                             Nao sao Multiplos
 */

using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);

            if(b % a == 0 || a % b == 0) {
                Console.WriteLine("Sao Multiplos");
            } 
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}