import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int horaInicial = sc.nextInt();
		int horaFinal = sc.nextInt();
		int horaTotal = 0;
		
		if (horaInicial < horaFinal)
        {
            horaTotal = horaFinal - horaInicial;
        }
        else {
            horaTotal = 24 - horaInicial + horaFinal;
        }
		
		System.out.println("O JOGO DUROU " + horaTotal + " HORA(S)");
		
		sc.close();
	}

}
