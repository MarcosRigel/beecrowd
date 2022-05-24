import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int contPar = 0;
        int contImpar = 0;
        int contPositivo = 0;
        int contNegativo = 0;
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int d = sc.nextInt();
        int e = sc.nextInt();
        
        if (a % 2 == 0) {
            contPar++;
        } 
        else {
            contImpar++;
        } 
        if (a > 0) {
            contPositivo++;
        } 
        if (a < 0) {
            contNegativo++;
        }
       
        if (b % 2 == 0) {
            contPar++;
        } 
        else {
            contImpar++;
        } 
        if (b > 0) {
            contPositivo++;
        } 
        if (b < 0) {
            contNegativo++;
        }
        
        if (c % 2 == 0) {
            contPar++;
        } 
        else {
            contImpar++;
        } 
        if (c > 0) {
            contPositivo++;
        } 
        if (c < 0) {
            contNegativo++;
        }
        
        if (d % 2 == 0) {
            contPar++;
        } 
        else {
            contImpar++;
        } 
        if (d > 0) {
            contPositivo++;
        } 
        if (d < 0) {
            contNegativo++;
        }
        
        if (e % 2 == 0) {
            contPar++;
        } 
        else {
            contImpar++;
        } 
        if (e > 0) {
            contPositivo++;
        } 
        if (e < 0) {
            contNegativo++;
        }
        
        System.out.println(contPar + " valor(es) par(es)");
        System.out.println(contImpar + " valor(es) impar(es)");
        System.out.println(contPositivo + " valor(es) positivo(s)");
        System.out.println(contNegativo + " valor(es) negativo(s)");
        
        sc.close();
    }
    
}
