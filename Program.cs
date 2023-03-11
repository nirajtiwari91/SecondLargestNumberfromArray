using System;

namespace _2ndLargestNumberfromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.SecondLargestNumberfromArray1();
            obj.SecondLargestNumberfromArray2();
            obj.SecondLargestNumberfromArray3();
            Console.ReadLine();
        }
        public void SecondLargestNumberfromArray1()
        {
            int[] myArray = new int[] { 10, 5, 7, 6, 9, 11, 14, 13 };
            Array.Sort(myArray);
            Array.Reverse(myArray);

            Console.WriteLine(myArray[1]);
        }

        public void SecondLargestNumberfromArray2()
        {
            int[] myArray = new int[] { 10, 5, 7, 6, 9, 11, 14, 13 };
            // Sort the array
            Array.Sort(myArray);

            int i;
            // Start from second last element
            // as the largest element is at last
            for (i = myArray.Length - 2; i >= 0; i--)
            {

                // If the element is not
                // equal to largest element
                if (myArray[i] != myArray[myArray.Length - 1])
                {
                    Console.Write(myArray[i]);
                    return;
                }
            }
        }

        public void SecondLargestNumberfromArray3()
        {
            int[] myArray = new int[] { 10, 5, 7, 6, 9, 11, 14, 13 };
            int largest = int.MinValue;
            int second = int.MinValue;

            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            Console.WriteLine(second);
        }
    }
}
