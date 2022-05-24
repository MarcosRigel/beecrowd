/* A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. Escreva um programa para
 * ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se
 * a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser 
 * encerrado imprimindo:
 * 
 * - Quantos GRENAIS fizeram parte da estatística.
 * - O número de vitórias do Inter.
 * - O número de vitórias do Grêmio.
 * - O número de Empates.
 * - Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).
 * 
 * Entrada
 * O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. 
 * Em seguida háverá um inteiro (1 ou 2), correspondente à repetição do programa.
 * 
 * Saída
 * Após cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)". Quando o algoritmo for encerrado devem ser
 * mostradas as estatísticas conforme a descrição apresentada acima. Obs: a palavra "Gremio" deve ser impressa sem acento, conforme o exemplo abaixo.
 * 
 * Exemplo
 * ==========================================================
 * Entrada                          Saída
 * ==========================================================
 * 3 2                              Novo grenal (1-sim 2-nao)
 * 1                                Novo grenal (1-sim 2-nao)
 * 2 3                              Novo grenal (1-sim 2-nao)
 * 1                                3 grenais
 * 3 1                              Inter:2
 * 2                                Gremio:1
 *                                  Empates:0
 *                                  Inter venceu mais
 */

using System;

namespace URI_1131 {
    class Program {
        static void Main(string[] args) {

            int gremio, inter;
            int vitoriaGremio = 0;
            int vitoriaInter = 0;
            int opcao = 0;
            int contadorGrenais = 0;
            int empates = 0;

            do {

                string[] vetor = Console.ReadLine().Split(' ');
                inter = int.Parse(vetor[0]);
                gremio = int.Parse(vetor[1]);

                if (gremio > inter) {
                    vitoriaGremio++;
                }
                else if (inter > gremio){
                    vitoriaInter++;
                } else {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                contadorGrenais = contadorGrenais + 1;


                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 2);

            Console.WriteLine(contadorGrenais + " grenais");
            Console.WriteLine("Inter:"+ vitoriaInter);
            Console.WriteLine("Gremio:"+ vitoriaGremio);
            Console.WriteLine("Empates:"+ empates);

            if(vitoriaGremio > vitoriaInter) {
                Console.WriteLine("Gremio venceu mais");
            } else if (vitoriaInter > vitoriaGremio){
                Console.WriteLine("Inter venceu mais");
            } else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
