/* Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).
 * 
 * Entrada
 * O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total
 * percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
 * 
 * Saída
 * Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
 * 
 * Exemplo
 * =================================================================
 * Entrada                                          Saída
 * =================================================================
 * 500                                              14.286 km/l
 * 35.0
 * =================================================================
 * 2254                                             18.119 km/l
 * 124.4
 * =================================================================
 * 4554                                             9.802 km/l
 * 464.6
 * 
 */


using System;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = x / y;

            Console.WriteLine(consumo.ToString("F3",CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
