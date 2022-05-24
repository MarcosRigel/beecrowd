import java.util.Locale;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int X, Y;
        double divisao;
        
        for (int i = 0; i < N; i++) {
            X = sc.nextInt();
            Y = sc.nextInt();
            if (Y == 0) {
                System.out.println("divisao impossivel");
            } else {
                divisao = (double) X / Y;
                System.out.printf("%.1f%n", divisao);
            }
        }
        
        sc.close();
    }
}
