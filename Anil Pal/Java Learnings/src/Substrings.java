
public class Substrings {

	
	public void findSubstring()
	{
		String str = new String("abcde");
		int charCounter =0;
		int strlen = str.length();
		System.out.println(str.codePointCount(0,3));
		System.out.println(str.substring(3));
		
		for ( int i=0; i<=str.length(); i++)
		{
			for (int j=i; j<=str.length(); j++)
			System.out.print(str.substring(i,j)+ " ");
		}// end of for loop
		System.out.println();
		
	}// end of FindSubstring method
	
}
