namespace DataStructuresAndAlgorithms
{
    public class InsertionSort
    {
        public static int[] Sort(int[] input)
        {
            int indexInQuestion;
            for (int i = 0; i < input.Length; i++)
            {
                indexInQuestion = input[i];

                int j = i;
                while (j > 0 && input[j - 1] > indexInQuestion)
                {
                    input[j] = input[j - 1];
                    j--;
                }
                input[j] = indexInQuestion;
            }
            return input;
        }
    }
}
