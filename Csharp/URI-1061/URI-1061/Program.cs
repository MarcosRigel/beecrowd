/* Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, 
 * iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar,
 * uma vez que ele sabe quando inicia e quando termina o evento.
 * 
 * Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.
 * 
 * Entrada
 * Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar.
 * Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de
 * entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.
 * 
 * Saída
 * Na saída, deve ser apresentada a duração do evento, no seguinte formato:
 * 
 * W dia(s)
 * X hora(s)
 * Y minuto(s)
 * Z segundo(s)
 * 
 * Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
 * 
 * Exemplo
 * ==================================================
 * Entrada                          Saída
 * ==================================================
 * Dia 5                            3 dia(s)
 * 08 : 12 : 23                     22 hora(s)
 * Dia 9                            1 minuto(s)
 * 06 : 13 : 23                     0 segundo(s)
 */

using System;

namespace URI_1061 {
    class Program {
        static void Main(string[] args) {
            int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, inicio, fim, duracao, resto;

            string[] valores = Console.ReadLine().Split(' ');
            w1 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            x1 = int.Parse(valores[0]);
            y1 = int.Parse(valores[2]);
            z1 = int.Parse(valores[4]);

            valores = Console.ReadLine().Split(' ');
            w2 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            x2 = int.Parse(valores[0]);
            y2 = int.Parse(valores[2]);
            z2 = int.Parse(valores[4]);

            inicio = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
            fim = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

            duracao = fim - inicio;

            w = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            x = resto / (60 * 60);
            resto = resto % (60 * 60);
            y = resto / 60;
            z = resto % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");
        }
    }
}
