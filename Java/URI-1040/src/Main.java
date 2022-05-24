import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		float N1, N2, N3, N4, media, N5;
		N1 = sc.nextFloat();
		N2 = sc.nextFloat();
		N3 = sc.nextFloat();
		N4 = sc.nextFloat();
		
		media = (N1*2f + N2*3f + N3*4f + N4*1f) / 10.0f;
		
		System.out.printf("Media: %.1f%n", media);
		
		if (media >= 7) {
			System.out.println("Aluno aprovado.");
		} else if (media < 5.0) {
			System.out.println("Aluno reprovado.");
		} else if (media >= 5.0 && media <= 6.9) {
			System.out.println("Aluno em exame.");
			N5 = sc.nextFloat();
			System.out.printf("Nota do exame: %.1f%n", N5);
			media = (media + N5) / 2.0f;
			if (media >= 5.0) {
				System.out.println("Aluno aprovado.");
			} else if (media <= 4.9) {
				System.out.println("Aluno reprovado.");
			}
			System.out.printf("Media final: %.1f%n", media);
		}
		
		sc.close();
	}

}
