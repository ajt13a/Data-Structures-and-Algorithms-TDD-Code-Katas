namespace DataStructAndAlgos
{
    public class BubbleSort
    {
        public static int[] Sort(int[] input)
        {
            for (int y = input.Length; y > 0; y--)
            {
                for (int x = 1; x < input.Length; x++)
                {
                    if (input.Length > 1)
                    {
                        if (input[x - 1] > input[x])
                        {
                            input = swap(input, x);
                        }
                    }
                }
            }
            return input;
        }

        private static int[] swap(int[] arrayToSwap, int x)
        {
            int temp = arrayToSwap[x];
            arrayToSwap[x] = arrayToSwap[x - 1];
            arrayToSwap[x - 1] = temp;
            return arrayToSwap;
        }
    }
}