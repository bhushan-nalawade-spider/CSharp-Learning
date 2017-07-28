import java.time.LocalDate;
import java.util.Scanner;

public class DateCheck {

	public void SetDateRange()
	{
		System.out.println("Enter the Start Date of the Date Range : ");
		Scanner scan = new Scanner(System.in);
		int stDt = scan.nextInt();
		System.out.println("Enter the End Date of the Date Range: ");
		int eDt = scan.nextInt();
		System.out.println("Enter the Off date range From value: ");
		int offStdt = scan.nextInt();

		System.out.println("Enter the Off date range To value : ");
		int offEdt = scan.nextInt();
		
		FindOnOffDate(stDt, eDt, offStdt, offEdt);
	}
	public void FindOnOffDate(int stDt, int eDt, int offStdt, int offEdt)
	{
		for (int i =stDt; i< eDt; i++)
			if (( i >= offStdt) && (i <= offEdt))
				System.out.println(i + " : Off" );
			else
				System.out.println(i + " : On" );
	}
}
