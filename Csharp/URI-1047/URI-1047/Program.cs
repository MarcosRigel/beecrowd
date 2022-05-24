/* Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
 * 
 * Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
 * 
 * Entrada
 * Quatro números inteiros representando a hora de início e fim do jogo.
 * 
 * Saída
 * Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
 * 
 * Exemplo
 * ==========================================================================
 * Entrada                              Saída
 * ==========================================================================
 * 7 8 9 10                             O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)
 * ==========================================================================
 * 7 7 7 7                              O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
 * ==========================================================================
 * 7 10 8 9                             O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)
 */


using System;

namespace URI_1047 {
    class Program {
        static void Main(string[] args) {
            
            string[] vetor = Console.ReadLine().Split(' ');
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);
            int d = int.Parse(vetor[3]);

            int horaInicial = a * 60 + b;
            int horaFinal = c * 60 + d;
            int tempo = 0;
            int horas = 0;
            int minutos = 0;

            if (horaInicial < horaFinal) {
                tempo = horaFinal - horaInicial;
            }
            else {
                tempo = (24 * 60 - horaInicial) + horaFinal;
            }

            horas = tempo / 60;
            minutos = tempo % 60;

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");

        }
    }
}
