using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOverlapNumbers
{
    internal class FindOverlapping
    {
        private static void Main(string[] args)
        {
           int[] firstRange = GetRange();
           int[] secondRange = GetRange();
           int indexOfFirstOverlappedValue =  GetFirstOverlappedValue(firstRange, secondRange);

            GetLastOverLappingValue(firstRange.Length,secondRange.Length,firstRange,secondRange, indexOfFirstOverlappedValue);
        }

        public static int[] GetRange()
        {
            int[] arrayRange = new int[] {};
            try
            {
                Console.Write('\n' + "Range starts from => ");
                int startingIndex = Int32.Parse(Console.ReadLine());
                Console.Write("Range ends from => ");
                int endingIndex = Int32.Parse(Console.ReadLine());
                int arraySize = endingIndex - startingIndex + 1;
                arrayRange = new int[arraySize];
                for (int indexOfRange = 0; indexOfRange < arraySize; indexOfRange++)
                {
                    arrayRange[indexOfRange] = startingIndex;
                    startingIndex = startingIndex + 1;
                    Console.Write(arrayRange[indexOfRange] + " ");
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                    Console.WriteLine("Please enter valid values..");
                System.Environment.Exit(0);
            }
            return arrayRange;
        }

        public static int GetFirstOverlappedValue( int[] firstRange,
            int[] secondRange)
        {
            int counter = 0;
            int indexOfFirstOverlappedValue = 0;
            int lengthOfFirstRange = firstRange.Length;
            int lengthOfSecondRange = secondRange.Length;

            for (int indexOfShorterRangeArray = 0;
                indexOfShorterRangeArray <= Math.Min(lengthOfFirstRange, lengthOfSecondRange) - 1;
                indexOfShorterRangeArray++)
            {
                if (counter > 0)
                    break;
                for (int indexofBiggerRangeArray = 0;
                    indexofBiggerRangeArray <= Math.Max(lengthOfFirstRange, lengthOfSecondRange) - 1;
                    indexofBiggerRangeArray++)
                {
                    if (lengthOfFirstRange - lengthOfSecondRange >= 0)
                    {
                        if (secondRange[indexOfShorterRangeArray] == firstRange[indexofBiggerRangeArray])
                        {
                            Console.WriteLine('\n'+ "Number matched . Overlap starts from " +
                                              secondRange[indexOfShorterRangeArray]);
                            counter = counter + 1;
                            break;
                        }
                    }
                    else if (firstRange[indexOfShorterRangeArray] == secondRange[indexofBiggerRangeArray])
                    {
                        Console.WriteLine("Number matched . Overlap starts from " + firstRange[indexOfShorterRangeArray]);
                        counter = counter + 1;
                        break;

                    }
                    indexOfFirstOverlappedValue = indexofBiggerRangeArray;
                }
            }
            if (counter == 0) Console.WriteLine('\n'+ " No Overlap Found!");


            return indexOfFirstOverlappedValue;

        }

        public static void GetLastOverLappingValue(int lengthOfFirstRange, int lengthOfSecondRange, int[] firstRange,
            int[] secondRange, int indexOfFirstOverlappedValue)
        {
            int counter = 0;

            if (lengthOfFirstRange - lengthOfSecondRange >= 0)
            {
                for (int startingIndexOfShorterRangeArray = lengthOfSecondRange - 1;
                    startingIndexOfShorterRangeArray >= 0;
                    startingIndexOfShorterRangeArray--)
                {
                    if (counter >= 1)
                        break;
                    {
                        for (int indexofBiggerRangeArray = indexOfFirstOverlappedValue;
                            indexofBiggerRangeArray <= lengthOfFirstRange - 1;
                            indexofBiggerRangeArray++)
                        {
                            if (secondRange[startingIndexOfShorterRangeArray] == firstRange[indexofBiggerRangeArray])
                            {
                                Console.WriteLine("And Overlap ends at " +
                                                  firstRange[indexofBiggerRangeArray]);
                                counter = counter + 1;
                                break;
                            }
                        }
                    }

                }
            }
            else
            {
                for (int startingIndexOfShorterRangeArray = lengthOfFirstRange - 1;
                    startingIndexOfShorterRangeArray >= 0;
                    startingIndexOfShorterRangeArray--)
                {
                    if (counter >= 1)
                        break;
                    {
                        for (int indexofBiggerRangeArray = indexOfFirstOverlappedValue;
                            indexofBiggerRangeArray <= lengthOfFirstRange - 1;
                            indexofBiggerRangeArray++)
                        {
                            if (firstRange[startingIndexOfShorterRangeArray] == secondRange[indexofBiggerRangeArray])
                            {
                                Console.WriteLine(" And Overlap ends at " +
                                                  firstRange[startingIndexOfShorterRangeArray]);
                                counter = counter + 1;
                                break;
                            }
                        }
                    }

                }
            }

        }


    }

}
