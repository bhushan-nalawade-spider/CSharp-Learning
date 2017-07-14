import java.util.ArrayList;

public class Arrays 
{

	public int[] bubbleSort (int[] arr)
	{
		int counter=0;
		int arrlen = arr.length;
		
		
		while (arrlen>0)
		{
			
		for ( counter=0; counter< arrlen-1; counter++)
			
		{
			if (arr[counter] >arr[counter +1])
			{
				int temp;
				temp =0;
				temp = arr[counter];
				arr[counter]=arr[counter+1];
				arr[counter+1]= temp;
			}
		}// end of For loop
		arrlen--;
		} // end of While Loop
		
		return arr;
	}
	
	public int[] FindMinMax (int arr[])
	{
		int[] minmax={320000,0};
		int counter;
		
		for ( counter=0; counter< arr.length; counter++)
			
			{
				if (arr[counter] < minmax[0] )
					{
					minmax[0] = arr[counter];
					}
				if (arr[counter] > minmax[1])
				{
					minmax[1] = arr[counter];
				}
				
			}// end of for loop
		return minmax;
		
	}// end of FindMinMax method
	
	public  void EvenOddArray (int arr[])
	{
		ArrayList<Integer> arreven = new ArrayList<Integer>();
		ArrayList<Integer> arrodd = new ArrayList<Integer>();
		int counter;
		int evencounter=0;
		int oddcounter=0;
		for ( counter=0; counter< arr.length; counter++)
			
			{
				if (arr[counter]%2==0 )
					{
					arreven.add(arr[counter]);
					
					}
				else
				{
					arrodd.add(arr[counter]);
				}
				
			}// end of for loop
		//Print Even List 
		System.out.println("The Even Number list is : ");
		for( int i=0; i< arreven.size(); i++)
		{
			System.out.print(arreven.get(i) + " " );
		}
// Print Odd List
		System.out.println("The Even Number list is : ");
		for( int i=0; i< arrodd.size(); i++)
		{
			System.out.print(arrodd.get(i) + " " );
		}

	}
}
