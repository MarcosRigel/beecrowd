import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double a, b, c;
		
		double x = sc.nextDouble();
		double y = sc.nextDouble();
		double z = sc.nextDouble();
		
		if (x > y && x > z)
        {
            a = x;
            if (y > z)
            {
                b = y;
                c = z;
            }
            else
            {
                b = z;
                c = y;
            }
        }

        else if (y > z)
        {
            a = y;
            if (x > z)
            {
                b = x;
                c = z;
            }
            else
            {
                b = z;
                c = x;
            }
        }
        else
        {
            a = z;
            if (x > y)
            {
                b = x;
                c = y;
            }
            else 
            {
                b = y;
                c = x;
            }
        }

        if (a >= b + c)
        {
        	System.out.println("NAO FORMA TRIANGULO");
        }

        else
        {
            if (Math.pow(a, 2) == Math.pow(b, 2) + Math.pow(c, 2))
            {
            	System.out.println("TRIANGULO RETANGULO");
            }
            else if (Math.pow(a, 2) > Math.pow(b, 2) + Math.pow(c, 2))
            {
            	System.out.println("TRIANGULO OBTUSANGULO");
            }
            else if (Math.pow(a, 2) < Math.pow(b, 2) + Math.pow(c, 2))
            {
            	System.out.println("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c)
            {
            	System.out.println("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c) {
            	System.out.println("TRIANGULO ISOSCELES");
            }
        }

	}

}
