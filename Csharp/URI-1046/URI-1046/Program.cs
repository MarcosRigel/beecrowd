/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar
 * em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
 * 
 * Entrada
 * A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
 * 
 * Saída
 * Apresente a duração do jogo conforme exemplo abaixo.
 * 
 * Exemplo:
 * ===================================================================
 * Entrada                              Saída
 * ===================================================================
 * 16 2                                 O JOGO DUROU 10 HORA(S)
 * ===================================================================
 * 0 0                                  O JOGO DUROU 24 HORA(S)
 * ===================================================================
 * 2 16                                 O JOGO DUROU 14 HORA(S)
 */

using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vetor[0]);
            int horaFinal = int.Parse(vetor[1]);
            int horaToTal = 0;

            if (horaInicial < horaFinal)
            {
                horaToTal = horaFinal - horaInicial;
            }
            else
            {
                horaToTal = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + horaToTal + " HORA(S)");

        }
    }
}
