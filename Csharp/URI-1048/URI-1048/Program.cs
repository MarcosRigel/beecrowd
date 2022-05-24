/* empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
 * 
 * ==========================================================================
 * Salário                                          Percentual de Reajuste
 * ==========================================================================
 * 0 - 400.00                                                   15%
 * 400.01 - 800.00                                              12%
 * 800.01 - 1200.00                                             10%
 * 1200.01 - 2000.00                                             7%
 * Acima de 2000.00                                              4%
 * 
 * Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho 
 * e o índice reajustado, em percentual.
 * 
 * Entrada
 * A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.
 * 
 * Saída
 * Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho,
 * conforme exemplo abaixo.
 * 
 * Exemplo:
 * ==========================================================================
 * Entrada                                      Saída
 * ==========================================================================
 * 400.00                                       Novo salario: 460.00
 *                                              Reajuste ganho: 60.00
 *                                              Em percentual: 15 %
 * ==========================================================================
 * 800.01                                       Novo salario: 880.01
 *                                              Reajuste ganho: 80.00
 *                                              em percentual: 10 %
 * ==========================================================================
 * 2000.00                                      Novo salario: 2140.00
 *                                              Reajuste ganho: 140.00
 *                                              Em percentual: 7 %
 */

using System;
using System.Globalization;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double reajuste = 0.0;

            if(salario <= 400.00)
            {
                reajuste = salario * 0.15;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            } 
            else if(salario >= 400.01 && salario <= 800.00) {
                reajuste = salario * 0.12;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00) {
                reajuste = salario * 0.10;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00) {
                reajuste = salario * 0.07;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00) {
                reajuste = salario * 0.04;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
