

public class OverlappingArrays {

	public void Datasetup()
	{	
	int[] arr1 = {12, 7, 5, 11, 14};
	int[] arr2 = {19, 7, 12, 11, 17};
	FindOverlappingArray( arr1, arr2);
	}
	
	public void FindOverlappingArray(int[] arr1, int[] arr2)
	{
		int[] sarr1;
		int[] sarr2;

		
		Arrays sarr = new Arrays();
		sarr1= sarr.bubbleSort(arr1);
		sarr2= sarr.bubbleSort(arr2);
	
		
		for ( int i : sarr1)
			for ( int j: sarr2)
				{
					if (i== j)
					{
						System.out.println(i);
					}
				}// end of for loop
		
		
		
		
	}	
}


