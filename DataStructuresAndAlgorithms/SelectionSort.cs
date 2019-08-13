namespace DataStructuresAndAlgorithms
{
    public class SelectionSort
    {
        public static int[] Sort(int[] input)
        {
            int size = input.Length;
            int minimum = 0;

            for (int x = 0; x < size - 1; x++)
            {
                minimum = x;

                for (int y = x + 1; y < size; y++)
                {
                    if (input[y] < input[minimum])
                    {
                        minimum = y;
                    }
                }

                if (minimum != x)
                {
                    input = swap(input, minimum, x);
                }
            }

            return input;
        }

        private static int[] swap(int[] arrayToSwap, int first, int second)
        {
            int temp = arrayToSwap[first];
            arrayToSwap[first] = arrayToSwap[second];
            arrayToSwap[second] = temp;
            return arrayToSwap;
        }
    }
}
