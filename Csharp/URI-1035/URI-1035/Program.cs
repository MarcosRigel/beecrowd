/* Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C 
 * e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".
 * 
 * Entrada
 * Quatro números inteiros A, B, C e D.
 * 
 * Saída
 * Mostre a respectiva mensagem após a validação dos valores. 
 * 
 * Exemplo
 * =======================================================================================================
 * Entrada                                                                      Saída
 * =======================================================================================================
 * 5 6 7 8                                                                      Valores nao aceitos
 * =======================================================================================================
 * 2 3 2 6                                                                      Valores aceitos
 * 
 */

using System;

namespace URI_1035
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int D = int.Parse(vet[3]);

            int somaCD = C + D;
            int somaAB = A + B;

            if(B > C && D > A && somaCD > somaAB && C > 0 & D > 0 && A % 2 == 0) {
                Console.WriteLine("Valores aceitos");
            } else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
