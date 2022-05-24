import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        String nome1, nome2, nome3;
        
        nome1 = sc.nextLine();
        nome2 = sc.nextLine();
        nome3 = sc.nextLine();
        
        if(nome1.equals("vertebrado")){
            if(nome2.equals("ave")) {
                if(nome3.equals("carnivoro")) {
                    System.out.println("aguia");
                }
                else if(nome3.equals("onivoro")) {
                    System.out.println("pomba");
                }
        }
        
        if(nome2.equals("mamifero")) {
                if(nome3.equals("onivoro")) {
                    System.out.println("homem");
                } else if(nome3.equals("herbivoro")){
                    System.out.println("vaca");
                }
            }
        }
        
        if(nome1.equals("invertebrado")) {
            if (nome2.equals("inseto")) {
                if (nome3.equals("hematofago")) {
                    System.out.println("pulga");
                } else if(nome3.equals("herbivoro")) {
                    System.out.println("largata");
                }
            } else if(nome2.equals("anelideo")) {
                if (nome3.equals("hematofago")) {
                    System.out.println("sanguessuga");
                } else if(nome3.equals("onivoro")){
                    System.out.println("minhoca");
                }
            }
        }
        
        sc.close();
    }
}
