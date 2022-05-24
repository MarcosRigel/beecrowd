import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double salario = sc.nextDouble();
		double reajusteGanho = 0.0;
		double novoSalario = 0.0;
		
		 if (salario == 0 || salario == 400.00) {
             reajusteGanho = salario * 0.15;
             novoSalario = salario + reajusteGanho;
             System.out.printf("Novo salario: %.2f%n", novoSalario);
             System.out.printf("Reajuste ganho: %.2f%n", reajusteGanho);
             System.out.printf("Em percentual: 15%");
         }

         if (salario == 400.01 || salario == 800.00) {
             reajusteGanho = salario * 0.12;
             novoSalario = salario + reajusteGanho;
             System.out.printf("Novo salario: %.2f%n", novoSalario);
             System.out.printf("Reajuste ganho: %.2f%n", reajusteGanho);
             System.out.printf("Em percentual: 12%");
         }

         if (salario == 800.01 || salario == 1200.00) {
             reajusteGanho = salario * 0.10;
             novoSalario = salario + reajusteGanho;
             System.out.printf("Novo salario: %.2f%n", novoSalario);
             System.out.printf("Reajuste ganho: %.2f%n", reajusteGanho);
             System.out.printf("Em percentual: 10%");
         }

         if (salario == 1200.01 || salario == 2000.00) {
             reajusteGanho = salario * 0.07;
             novoSalario = salario + reajusteGanho;
             System.out.printf("Novo salario: %.2f%n", novoSalario);
             System.out.printf("Reajuste ganho: %.2f%n", reajusteGanho);
             System.out.printf("Em percentual: 7%");
         }

         if (salario > 2000.00) {
             reajusteGanho = salario * 0.04;
             novoSalario = salario + reajusteGanho;
             System.out.printf("Novo salario: %.2f%n", novoSalario);
             System.out.printf("Reajuste ganho: %.2f%n", reajusteGanho);
             System.out.printf("Em percentual: 4%");
         }
		
		sc.close();
	}

}
