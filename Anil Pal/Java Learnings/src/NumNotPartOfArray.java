
public class NumNotPartOfArray {
	
	
	public void DataSetUp()
	{
		int[] arr1 = {3, 4, 8, 9, 12};
		int startNum = 2;
		int endNum = 15;
		
		FindNumNotPartOfArray(arr1, startNum, endNum);
	}
	public void FindNumNotPartOfArray(int[] arr, int StartVal, int EndVal)
	{
		
//		e.g Array [3, 4, 8, 9, 12]
//				Start=3
//				end=15
//				output=> 5, 6, 7, 10, 11, 13, 14, 15

		int[] sortarray;
		int outCounter;
		int inCounter;
		int temp=0;
		boolean flag = false;
		if (StartVal > EndVal)
		{
			temp = StartVal ;
			StartVal = EndVal;
			EndVal = temp;
		}//end of If . Check if Startval is greater than EndVal then reverse it
		Arrays sortarr = new Arrays();
		sortarray= sortarr.bubbleSort(arr);
		
		for ( outCounter=StartVal ; outCounter<=EndVal; outCounter++)
		{
			flag = false;
			 for ( int i: sortarray )
			 {

				 if (outCounter==i )
							  {
						  		flag = true;
						  		break;
							  }
			 }// end of Inner For Loop
			 
			 if (flag == false)
				 System.out.println(outCounter);
	
		}//end of For loop

	}//end Of FindNumNotPartOfArray method

}

