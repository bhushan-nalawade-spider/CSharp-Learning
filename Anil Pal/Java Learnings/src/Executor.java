import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import InterfacesExceptions.MyShape;
import InterfacesExceptions.MyParentClass;

public class Executor {

	public static void main(String[] args) throws Exception {
		// TODO Auto-generated method stub

		
		
// Wrapper Class in Java . Boxing and Unboxing
		
		int i= 5;
		Integer j = new Integer(i); // Boxing
		
		int k = j.intValue(); //Unboxing 
		
		
		System.out.println("Primitive Type: " + i);
		System.out.println("Wrapper Class: " + j);
		System.out.println("Unboxed: " + k);
		
		
		
/*// Assignement : Sort the Array 		
		Arrays sort = new Arrays();
		int arr[]= {20,15,13,9,5,1};
		int resarr[] = sort.bubbleSort(arr);
		
		System.out.println("Find Min and Max of an Array ");
		for (int counter =0; counter< resarr.length; counter++)
		{
			System.out.print( resarr[counter] + " " );
		}*/
		
/*//	Find min and Max of an Array	
int minmaxarr[]= {20,15,13,9,5,1};
int arrres[] ;
	int arrRes[]=	sort.FindMinMax(minmaxarr);
		
		System.out.println(" ");
		System.out.println("Find Min and Max of an Array ");
		System.out.println("The min number from the Array is : " + arrRes[0]);
		System.out.println(" The Max  number from the Array is : " + arrRes[1]);
		
*/
/*//Program to Print a Binary Triangle

System.out.println("Create the Binary Tree");
		BinaryTriangle binT = new BinaryTriangle();
		binT.CreateBinaryTriangle( 6);
		*/
		
/*// Write a programin C# Sharp to separate odd and even integers in separate arrays
		int evenodd[]= {20,15,13,9,5,1};
		sort.EvenOddArray(arr);
		
// Read from excel file and verify if it is a prime number or not
		
		FindIfPrime fp = new FindIfPrime();
		try {
			fp.ReadFromFile();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}*/
/*//3.Find the Frequency of the Word “the” in a given Sentence
		
		StringFunctions sf = new StringFunctions();
		sf.FindWordFrequency();
		sf.FindCharWordLineCount();
		*/
		
//6. Find unique Substrings
		
		Substrings fs = new Substrings();
		fs.findSubstring();
		

/*//10. Inheritance Calling Parent and child constructors
		
		ChildClass cc = new ChildClass(); 
	
	*/
/*//Page 2 Program 2: Implement Inheritance using interfaces	
	
 MyShape cal = new MyShape();
 double area;
 try{
	 

 area = cal.CalArea();
 cal.CalCost(area);
 }
 catch ( Exception e)
 {
	 System.out.println("Exception occured" + e.getStackTrace());
 }*/
 
 
 // Page 2  Program# 4 Simulate Calculator
 //MyCalculator calc = new MyCalculator();
 //calc.InputNumbers();
 
 
 /*//Page 2 Program #5
 NumNotPartOfArray  notanarray= new NumNotPartOfArray();
 notanarray.DataSetUp();*/
 
/*//Page 2 Program #6
OverlappingArrays  arro= new OverlappingArrays();
arro.Datasetup();*/

/*//Page 2 Program #8

DateCheck dc = new DateCheck();
dc.SetDateRange();*/
		
		
//Page 2 Program #7
		
	}

	}
			
	
	