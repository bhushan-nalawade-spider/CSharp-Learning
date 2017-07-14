import java.util.ArrayList;

public class StringFunctions {

		
	public void FindWordFrequency()
	{
		int counter;
		int wordcounter=0;
		String searchIn =  new String ("I got the duck like 5 times, the mouse 5 times too, and the pet, the fly and the horse only once. When I try to go back to repeat the lesson, I still get the same words, and I still have reviewed \"pet\" only once.");
		String tosearch = new String ("the");
		
		
		for ( counter=0; counter< searchIn.length(); counter++)
		{
			//System.out.print( searchIn.charAt(counter));
			if ((searchIn.charAt(counter)==' ') && (searchIn.charAt(counter +4)==' '))
				{
					
					//		if ((searchIn.substring(counter+1, counter +4))=="the")
				if ((searchIn.substring(counter+1, counter +4)).equalsIgnoreCase("the"))
							{
								wordcounter = wordcounter+1;
							}
				}
				
				
			}
		
			System.out.println("\n The count of the word \"The \" in the given sentence is :" + wordcounter );
		
	
	}



public void FindCharWordLineCount()
{
	int counter;
	int wordcounter=0;
	int charcounter=0;
	int linecounter=1;
	
	String searchIn =  new String ("This has happened to me several times, but I'm not sure how to report it.\nSo I repeated the lesson immediately to practice the other words, and the same thing happened again! I get that heureux has an odd declension pattern, but I feel that the other words barely got any practice. \nFor instance, today I did lesson one of Adjectives 4 in French, and I got about 10 sentences in a row with \"heureux\"");
	
	
	
	for ( counter=0; counter< searchIn.length(); counter++)
	
	{
		switch(searchIn.charAt(counter))
		{
		case ' ' :
		wordcounter = wordcounter +1;
		charcounter = charcounter + 1;
		break;
		
		case '\n':
			linecounter = linecounter +1;
			charcounter = charcounter + 1;
			break;
			
		default :
			charcounter = charcounter + 1;
			
		}// end of switch statement
	
			
			
		}// end of for loop
	
		System.out.println("\n Number of lines : " + linecounter );
		System.out.println("Number of Words : " + wordcounter );
		System.out.println("Number of Characters : " + charcounter );
	

}

}