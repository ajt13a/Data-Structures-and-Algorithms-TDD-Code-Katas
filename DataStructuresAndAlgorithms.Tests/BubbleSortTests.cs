using Xunit;
using DataStructuresAndAlgorithms;

namespace DataStructuresAndAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_GivenEmptyArray_ReturnsArray()
        {
            int[] expected = new int[0];
            int[] actual = DataStructuresAndAlgorithms.BubbleSort.Sort(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BubbleSort_GivenArrayOfOneElement_ReturnsArray()
        {
            int[] expected = new int[] { 1 };
            int[] actual = BubbleSort.Sort(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BubbleSort_GivenArrayOfTwoElement_ReturnsSortedArray()
        {
            int[] input = new int[] { 2, 1 };
            int[] expected = new int[] { 1, 2 };
            int[] actual = BubbleSort.Sort(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BubbleSort_GivenArrayOfManyElements_ReturnsSortedArray()
        {
            int[] input = new int[] { 2, 1, 8, 4, 55, 22, 0, 29, 11 };
            int[] expected = new int[] { 0, 1, 2, 4, 8, 11, 22, 29, 55 };
            int[] actual = BubbleSort.Sort(input);
            Assert.Equal(expected, actual);
        }
    }
}
