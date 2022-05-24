/* Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, 
 * quantos valores digitados foram positivos e quantos valores digitados foram negativos.
 * 
 * Entrada
 * O arquivo de entrada contém 5 valores inteiros quaisquer.
 * 
 * Saída
 * Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.
 * 
 * Exemplo
 * ====================================================================
 * Entrada                                      Saída
 * ====================================================================
 * -5                                           3 valor(es) par(es)    
 * 0                                            2 valor(es) impar(es)  
 * -3                                           1 valor(es) positivo(s)
 * -4                                           3 valor(es) negativo(s)
 * 12
 */

using System;

namespace URI_1066 {
    class Program {
        static void Main(string[] args) {

            int numeros;
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;

            for (int i = 0; i < 5; i++) {
                numeros = int.Parse(Console.ReadLine());

                if (numeros % 2 == 0) {
                    par++;
                } 
                else {
                    impar++;
                }

                if (numeros > 0) {
                    positivo++;
                } 
                else if (numeros < 0){
                    negativo++;
                }

            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
