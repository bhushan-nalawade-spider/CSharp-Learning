import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Executor {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

// Assignement : Sort the Array 		
		Arrays sort = new Arrays();
		int arr[]= {20,15,13,9,5,1};
		int resarr[] = sort.bubbleSort(arr);
		
		System.out.println("Find Min and Max of an Array ");
		for (int counter =0; counter< resarr.length; counter++)
		{
			System.out.print( resarr[counter] + " " );
		}
		
//	Find min and Max of an Array	
int minmaxarr[]= {20,15,13,9,5,1};
int arrres[] ;
	int arrRes[]=	sort.FindMinMax(minmaxarr);
		
		System.out.println(" ");
		System.out.println("Find Min and Max of an Array ");
		System.out.println("The min number from the Array is : " + arrRes[0]);
		System.out.println(" The Max  number from the Array is : " + arrRes[1]);
		

//Program to Print a Binary Triangle

System.out.println("Create the Binary Tree");
		BinaryTriangle binT = new BinaryTriangle();
		binT.CreateBinaryTriangle( 6);
		
		
// Write a programin C# Sharp to separate odd and even integers in separate arrays
		int evenodd[]= {20,15,13,9,5,1};
		sort.EvenOddArray(arr);
		
		
//3.Find the Frequency of the Word “the” in a given Sentence
		
		StringFunctions sf = new StringFunctions();
		sf.FindWordFrequency();
		sf.FindCharWordLineCount();
		
	}
	}
			
	
	