import java.awt.event.KeyEvent;
import java.util.Scanner;
import java.util.*;

public class MyCalculator {
	
	public double AddNum (double num1, double num2)
	{
		double sum;
		sum = num1+num2;
		return sum;
	}

	public double SubNum (double num1, double num2)
	{
		double diff;
		diff = num1- num2;
		return diff;
	}
	public double MulNum (double num1, double num2)
	{
		double mul;
		mul = num1*num2;
		return mul;
	}
	public double DivNum (double num1, double num2)
	{
		double div;
		div = num1/num2;
		return div;
	}
	
	public void InputNumbers ()
	{
		
		double num1;
		double num2;
		char operation;
		double res;
		boolean flag =true;
	
		Scanner scan = new Scanner(System.in);
				
		while (flag)
		{
		System.out.println("Enter the Operation from +, -, *, / and Any other character to exit");
		operation = scan.next().charAt(0);
		
		switch( operation)
		{
		case '+' :
			System.out.println("Enter first number");
			num1 = scan.nextDouble();
			System.out.println("Enter Second number");
			num2 = scan.nextDouble();
			
			res=0;
			res= AddNum(num1,num2);
			System.out.println("The Sum of  " + num1 + " and " + num2 + " is :  " + res) ;
			break;
		case '-' :
			System.out.println("Enter first number");
			num1 = scan.nextDouble();
			System.out.println("Enter Second number");
			num2 = scan.nextDouble();
			
			res=0;
			res= SubNum(num1,num2);
			System.out.println("The Difference of  " + num1 + " and " + num2 + " is :  " + res) ;
			break;
		case '*' :
			System.out.println("Enter first number");
			num1 = scan.nextDouble();
			System.out.println("Enter Second number");
			num2 = scan.nextDouble();
			
			res=0;
			res= MulNum(num1,num2);
			System.out.println("The Multiplication of  " + num1 + " and " + num2 + " is :  " + res) ;
			break;

		case '/' :
			System.out.println("Enter first number");
			num1 = scan.nextDouble();
			System.out.println("Enter Second number");
			num2 = scan.nextDouble();
			
			res=0;
			res= DivNum(num1,num2);
			System.out.println("The Division of  " + num1 + " and " + num2 + " is :  " + res) ;
			break;
		
		default: 
			
			flag=false;			
			System.out.println("You have choosen an option other than required. This will end the program")	;
		}// end of Switch
			
		}//end of While loop
		scan.close();	
	}// end of InputNumbers method

}
