import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, inicio, fim, duracao, resto;
		String s;
		
		s = sc.next();
        w1 = sc.nextInt();
        x1 = sc.nextInt();
        s = sc.next();
        y1 = sc.nextInt();
        s = sc.next();
        z1 = sc.nextInt();
        s = sc.next();
        w2 = sc.nextInt();
        x2 = sc.nextInt();
        s = sc.next();
        y2 = sc.nextInt();
        s = sc.next();
        z2 = sc.nextInt();

        inicio = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
        fim = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

        duracao = fim - inicio;

        w = duracao / (24 * 60 * 60);
        resto = duracao % (24 * 60 * 60);
        x = resto / (60 * 60);
        resto = resto % (60 * 60);
        y = resto / 60;
        z = resto % 60;

        System.out.println(w + " dia(s)");
        System.out.println(x + " hora(s)");
        System.out.println(y + " minuto(s)");
        System.out.println(z + " segundo(s)");
        
        sc.close();

	}

}
