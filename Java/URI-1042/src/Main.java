import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        
        if(a > b && a > c) {
            if (b > c) {
                System.out.println(c);
                System.out.println(b);
                System.out.println(a);
            } else {
                System.out.println(b);
                System.out.println(c);
                System.out.println(a);
            }
        }
        
        if (a < b && a < c) {
            if (b > c) {
                System.out.println(a);
                System.out.println(c);
                System.out.println(b);
            } else {
                System.out.println(a);
                System.out.println(b);
                System.out.println(c);
            }
        }
        
        if (a > b && a < c) {
            if (b > c) {
                System.out.println(c);
                System.out.println(a);
                System.out.println(b);
            } else {
                System.out.println(b);
                System.out.println(a);
                System.out.println(c);
            }
        }
        
        if (a < b && a > c) {
            if (b > c) {
                System.out.println(c);
                System.out.println(a);
                System.out.println(b);
            } else {
                System.out.println(b);
                System.out.println(a);
                System.out.println(c);
            }
        }
        System.out.println();
        System.out.println(a);
        System.out.println(b);
        System.out.println(c);
        
        sc.close();
    }
}
