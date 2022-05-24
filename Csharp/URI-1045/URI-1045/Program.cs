/* Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo 
 * que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
 * se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
 * se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
 * se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
 * se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
 * se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
 * se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
 * 
 * Entrada
 * A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).
 * 
 * Saída 
 * Imprima todas as classificações do triângulo especificado na entrada.
 * 
 * Exemplo:
 * ==========================================================
 * Entrada                              Saída
 * ==========================================================
 * 7.0 5.0 7.0                          TRIANGULO ACUTANGULO
 *                                      TRIANGULO ISOSCELES
 * ==========================================================
 * 6.0 6.0 10.0                         TRIANGULO OBTUSANGULO
 *                                      TRIANGULO ISOSCELES
 * ==========================================================
 * 6.0 6.0 6.0                          TRIANGULO ACUTANGULO
 *                                      TRIANGULO EQUILATERO
 * ==========================================================
 * 5.0 7.0 2.0                          NAO FORMA TRIANGULO
 * ==========================================================
 * 6.0 8.0 10.0                         TRIANGULO RETANGULO
 */


using System;
using System.Globalization;

namespace URI_1045 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double maiorX = 0.0;
            double maiorY = 0.0;
            double maiorZ = 0.0;

            if (x > y && x > z) {
                maiorX = x;
                if (y > z) {
                    maiorY = y;
                    maiorZ = z;
                }
                else {
                    maiorY = z;
                    maiorZ = y;
                }
            }

            else if (y > z) {
                maiorX = y;
                if (x > z) {
                    maiorY = x;
                    maiorZ = z;
                }
                else {
                    maiorY = z;
                    maiorZ = x;
                }
            }
            else {
                maiorX = z;
                if (x > y) {
                    maiorY = x;
                    maiorZ = y;
                }
                else {
                    maiorY = y;
                    maiorZ = x;
                }
            }

            if (maiorX >= maiorY + maiorZ) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else {
                if (Math.Pow(maiorX, 2) == Math.Pow(maiorY, 2) + Math.Pow(maiorZ, 2)) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(maiorX, 2) > Math.Pow(maiorY, 2) + Math.Pow(maiorZ, 2)) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(maiorX, 2) < Math.Pow(maiorY, 2) + Math.Pow(maiorZ, 2)) {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (maiorX == maiorY && maiorY == maiorZ) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (maiorX == maiorY || maiorX == maiorZ || maiorY == maiorZ) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
