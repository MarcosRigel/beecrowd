/* Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). 
 * A seguir, mostre a quantidade de valores positivos digitados.
 * 
 * Entrada
 * Seis valores, negativos e/ou positivos.
 * 
 * Saída
 * Imprima uma mensagem dizendo quantos valores positivos foram lidos.
 * 
 * Exemplo
 * =================================================================
 * Entrada                                      Saída
 * =================================================================
 * 7                                            4 valores positivos
 * -5
 * 6
 * -3.4
 * 4.6
 * 12
 * 
 */

using System;

namespace URI_1060 {
    class Program {
        static void Main(string[] args) {

            double contadorPositivo = 0.0;
            
            double numero = double.Parse(Console.ReadLine());
            if(numero > 0.0) {
                contadorPositivo++;
            }

            numero = double.Parse(Console.ReadLine());
            if (numero > 0.0) {
                contadorPositivo++;
            }
            
            numero = double.Parse(Console.ReadLine());
            if (numero > 0.0) {
                contadorPositivo++;
            }
            
            numero = double.Parse(Console.ReadLine());
            if (numero > 0.0) {

            }
            
            numero = double.Parse(Console.ReadLine());
            if (numero > 0.0) {
                contadorPositivo++;
            }
            
            numero = double.Parse(Console.ReadLine());
            if (numero > 0.0) {
                contadorPositivo++;
            }

            Console.WriteLine(contadorPositivo + " valores positivos");
        }
    }
}
