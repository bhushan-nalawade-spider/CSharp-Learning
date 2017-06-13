using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeExcercises;
namespace PracticeExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Excercises:");
            int option = 0;
            do
            {
                DiplayMenu();
                string key = Console.ReadLine();
                try
                {
                    option = int.Parse(key);
                }
                catch (Exception)
                {
                    Console.WriteLine("you have not entered integer value");
                }
                switch (key)
                {
                    case "1":
                        Ex1_ArrayNumbers a = new Ex1_ArrayNumbers();
                        int[] IntArray = Ex1_ArrayNumbers.AddIntegersToArrray();
                        Ex1_ArrayNumbers.FindLargestSmallestFromAnArray(IntArray);
                        break;

                    case "2":
                        Ex2_PrimeFromFile prime = new Ex2_PrimeFromFile();
                        string fileName = @"D:\MyDir\numbers.csv";
                        string numbers = prime.ReadFromFile(fileName);
                        prime.PrintPrimeNumbersFromFile(numbers);
                        break;
                    case "3":
                        Ex3_WordFrequency wf = new Ex3_WordFrequency();
                        wf.FindWordFrequency();
                        //Console.WriteLine("Not ready now");
                        break;
                    case "4":
                        string flieName = @"D:\MyDir\linesFile.txt";
                        Ex4_FileMetadata fm = new Ex4_FileMetadata();
                        Console.WriteLine("no of lines in file: "+  fm.CountLines(flieName) );
                        Console.WriteLine("no of words in file: "+ fm.CountWordsFromFile(flieName));
                        break;
                    case "5":
                        Ex5_BinaryTraingle BinaryTriangle = new Ex5_BinaryTraingle();
                        BinaryTriangle.PrintBinaryTriangle(5);
                        break;
                    case "6":
                        Ex6_UniqueSubstringCombinations uniquecombinations = new Ex6_UniqueSubstringCombinations();
                        uniquecombinations.FindUniqueSubstringCombinations();
                        break;
                    case "7":
                        EX7_DeleteFile DeleteFile = new EX7_DeleteFile();
                        DeleteFile.DeleteFileFrom("D:\\MyDir");
                        break;
                    case "8":
                        EX8_DuplicateElementsInAnArray duplicateElements = new EX8_DuplicateElementsInAnArray();
                        duplicateElements.FindDuplicates();
                        break;
                    case "9":
                        int[] IntegerArray = Ex1_ArrayNumbers.AddIntegersToArrray();
                        Ex9_SeparateEvenOddNumbersOfArrayElements EvenOddElements = new Ex9_SeparateEvenOddNumbersOfArrayElements();
                        EvenOddElements.findEvenOddNumberOfArrayElements(IntegerArray);
                        break;
                    case "10":
                        Parent p = new Child();
                        Child.Print();
                        p.Print();
                        Console.ReadKey();
                        break;
                }
            } while (option <= 10);
        }
        static void DiplayMenu()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("1. Find largest and smallest integer from a given array of 4 numbers:");
            Console.WriteLine("2. Read set of numbers from a csv file and verify each number is Prime or not :");
            Console.WriteLine("3. Find the Frequency of the Word “the” in a given Sentence:");
            Console.WriteLine("4. Count the number of words, lines (chars):");
            Console.WriteLine("5. Print a Binary Triangle:");
            Console.WriteLine("6. List all possible unique substrings in a given String:");
            Console.WriteLine("7. Delete a file from the particular location:");
            Console.WriteLine("8. Count a total number of duplicate elements in an array:");
            Console.WriteLine("9. Separate odd and even integers in separate arrays:");
            Console.WriteLine("10. Inheritance to display the output :");
            Console.Write("Please enter your choice 1 to 10, enter 11 to exit: ");
         }
   }
}
