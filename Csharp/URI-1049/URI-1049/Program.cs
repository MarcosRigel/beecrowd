/* Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  
 * Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
 *                              
 *                             |---> carnivoro ---> aguia
 *                    |---> ave|
 *                    |        |---> onivoro ---> pomba
 *          vertebrado|
 *                    |             |---> onivoro ---> homem
 *                    |---> mamifero|
 *                                  |---> herbivoro ---> vaca
 *                      
 *                      
 *                                  |---> hematofago ---> pulga
 *                      |---> inseto|
 *                      |           |---> herbivoro ---> largata
 *                      |
 *          invertebrado|
 *                      |             |---> hematofago ---> sanguessuga
 *                      |---> anelideo|
 *                                    |---> onivoro ---> minhoca
 *          
 * 
 * Entrada
 * A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.
 * 
 * Saída
 * Imprima o nome do animal correspondente à entrada fornecida.
 * 
 * Exemplo:
 * ==================================================================
 * Entrada                                          Saída
 * ==================================================================
 * vertebrado                                       homem
 * mamifero
 * onivoro
 * ==================================================================
 * vertebrado                                       aguia
 * ave
 * carnivoro
 * ==================================================================
 * invertebrado                                     minhoca
 * anelideo
 * onivoro
 */


using System;

namespace URI_1049 {
    class Program {
        static void Main(string[] args) {

            string nome1, nome2, nome3;

            nome1 = Console.ReadLine();
            nome2 = Console.ReadLine();
            nome3 = Console.ReadLine();

            if (nome1 == "vertebrado") {
                if (nome2 == "ave") {
                    if (nome3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else {
                        Console.WriteLine("pomba");
                    }
                }
                else {
                    if (nome3 == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else {
                if (nome2 == "inseto") {
                    if (nome3 == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else {
                        Console.WriteLine("lagarta");
                    }
                }
                else {
                    if (nome3 == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
