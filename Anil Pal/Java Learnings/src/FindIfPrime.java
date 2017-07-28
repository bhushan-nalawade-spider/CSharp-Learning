import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;

import org.apache.poi.*;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;


public class FindIfPrime {

	public void ReadFromFile() throws Exception
	{
		String strfilepath = "D:\\Anil@SpiderLogic\\Automation\\Self Training\\JAVA\\FindPrimeNo.xlsx";
		FileInputStream fis = new FileInputStream(strfilepath);
		XSSFWorkbook wb = new XSSFWorkbook(fis);
		XSSFSheet sh=   wb.getSheetAt(0);
		int rownum = 0;
		int maxrow = sh.getLastRowNum();
		
		for ( rownum =1; rownum <maxrow; rownum++ )
		{
			String cellval= new String ( sh.getRow(0).getCell(0).getStringCellValue());
			FindPrime(Integer.parseInt(cellval));
		}// end of for loop
		
		fis.close();
		
	}
	
	public boolean FindPrime(int num)
	{
		for (int count=3; count <num; count++)
			
		{
			boolean blnIsPrime;
			if (num%count ==0)
			{
				blnIsPrime = false;
			}
			else
				blnIsPrime = true;
			
		}//end of for Loop
		return true;
		
	}// end of FindPrime method
}
