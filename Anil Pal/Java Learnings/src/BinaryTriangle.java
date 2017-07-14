
public class BinaryTriangle {

	
	public void CreateBinaryTriangle(int row)
		{
		int[] binnum=new int[row];
			for (int i=0; i<row; i++)
				{
				
					if (i%2==0 )
					{
						binnum[i]=0;
					}
					else
					{
						binnum[i]=1;
					}
					for (int j=0; j<=i; j++)
					{
						System.out.print(binnum[j]);
					}
					System.out.println(" ");
					
	
				}// end of for loop
		}
}
