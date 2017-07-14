//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pr6_OverlappingSectionInArrays
//{
//    class Pr6_OverlappingSectionInArrays
//    {
//        //static void Main(string[] args)
//        {
//            int arraySize = 0;

//            Console.WriteLine("Enter the size of the array: ");
//            arraySize = getInteger();

//            int[] sampleArray1 = createArray(arraySize);
//            int[] sampleArray2 = createArray(arraySize);
//            int[] overlappedArray = GetOverlappedArray(sampleArray1, sampleArray2);
//        }

//        private static int[] GetOverlappedArray(int[] sampleArray1, int[] sampleArray2)
//        {
//            sampleArray1 = sortArray(sampleArray1);
//            sampleArray2 = sortArray(sampleArray2);



//            int lowerBoundry = 0, upperboundry = 0;

//            lowerBoundry = DecideLowerBoundryOfOverlappedArray(sampleArray1, sampleArray2);
//            upperboundry = DecideUpperBoundryOfOverlappedArray(sampleArray1, sampleArray2);


//            List<int> overlappedList = new List<int>();

//            foreach (int i in sampleArray1)
//            {
//                foreach (int j in sampleArray2)
//                {
//                    if (i == j)
//                    {
//                        overlappedList.Add(i);
//                    }
//                }
//            }

//            int overlappedArraySize = overlappedList.Count;
//            int[] overlappedArray = new int[overlappedArraySize];

//            return overlappedArray;
//        }

//        private static int DecideOverlappedArraySize(int[] sampleArray1, int[] sampleArray2, int lowerBoundry, int upperboundry)
//        {
//            int overlappedArraySize = 0;

//            for (int i = lowerBoundry; i <= upperboundry; i++)
//            {
//                bool presentInFirst = false;
//                foreach (int j in sampleArray1)
//                {
//                    if (i == j)
//                    {
//                        presentInFirst = true;
//                        overlappedArraySize++;
//                        break;
//                    }
//                }
//                foreach (int k in sampleArray2)
//                {
//                    if (i == k)
//                    {
//                        if (!presentInFirst)
//                        {
//                            overlappedArraySize++;
//                            break;
//                        }
//                        else
//                        {
//                            break;
//                        }

//                    }
//                }
//            }
//            return overlappedArraySize;
//        }

//        private static int DecideUpperBoundryOfOverlappedArray(int[] sampleArray1, int[] sampleArray2)
//        {
//            int upperboundry;
//            if (sampleArray1[sampleArray1.Length - 1] < sampleArray2[sampleArray2.Length - 1])
//            {
//                upperboundry = sampleArray1[sampleArray1.Length - 1];
//            }
//            else
//            {
//                upperboundry = sampleArray2[sampleArray2.Length - 1];
//            }
//            return upperboundry;
//        }

//        private static int DecideLowerBoundryOfOverlappedArray(int[] sampleArray1, int[] sampleArray2)
//        {
//            int lowerBoundry;
//            if (sampleArray1[0] > sampleArray2[0])
//            {
//                lowerBoundry = sampleArray1[0];
//            }
//            else
//            {
//                lowerBoundry = sampleArray2[0];
//            }
//            return lowerBoundry;
//        }

//        private static int getInteger()
//        {
//            int reqInt = 0;
//            try
//            {
//                reqInt = Convert.ToInt32(getConsoleInput());
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.StackTrace);
//            }
//            return reqInt;
//        }

//        private static string getConsoleInput()
//        {
//            String str = null;

//            try
//            {
//                str = Console.ReadLine();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.StackTrace);
//            }

//            return str;
//        }

//        private static int[] createArray(int arraySize)
//        {

//            int[] sampleArray = new int[arraySize];

//            for (int number = 0; number < arraySize; number++)
//            {
//                Console.WriteLine("Enter number " + (number + 1) + " :");
//                int enteredNum = getInteger();
//                sampleArray[number] = enteredNum;
//            }

//            return sampleArray;
//        }

//        private static int[] sortArray(int[] sampleArray)
//        {
//            int temp = 0;
//            for (int i = 0; i < sampleArray.Length; i++)
//            {
//                for (int j = i; j < sampleArray.Length; j++)
//                {
//                    if (sampleArray[i] > sampleArray[j])
//                    {
//                        temp = sampleArray[i];
//                        sampleArray[i] = sampleArray[j];
//                        sampleArray[j] = temp;
//                    }
//                }

//            }

//            return sampleArray;
//        }
//    }
//}
