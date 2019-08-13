using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 5, 84, 98, 3, 25, 1, 65, 64, 6, 55 };

            Console.Write("Original array: { ");
            PrintArray(testArray);

            Console.Write("BubbleSorted array: { ");
            int[] resultBubbleSortArray = BubbleSort.Sort(testArray);
            PrintArray(resultBubbleSortArray);

            Console.Write("InsertionSorted array: { ");
            int[] resultInsertionSortArray = BubbleSort.Sort(testArray);
            PrintArray(resultInsertionSortArray);

            Console.ReadKey();
        }

        private static void PrintArray(int[] testArray)
        {
            for (int x = 0; x < testArray.Length - 1; x++)
            {
                Console.Write(testArray[x] + ", ");
            }
            Console.WriteLine(testArray[testArray.Length - 1] + " }");
        }
    }
}
