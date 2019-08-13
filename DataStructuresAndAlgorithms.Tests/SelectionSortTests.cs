using System;
using Xunit;

namespace DataStructuresAndAlgorithms.Tests
{
    public class SelectionSortTests
    {
        [Fact]
        public void InsertionSort_GivenEmptyArray_ReturnsArray()
        {
            int[] expected = new int[0];
            int[] actual = SelectionSort.Sort(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertionSort_GivenArrayOfOneElement_ReturnsArray()
        {
            int[] expected = new int[] { 1 };
            int[] actual = SelectionSort.Sort(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertionSort_GivenArrayOfTwoElement_ReturnsSortedArray()
        {
            int[] input = new int[] { 2, 1 };
            int[] expected = new int[] { 1, 2 };
            int[] actual = SelectionSort.Sort(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertionSort_GivenArrayOfThreeElement_ReturnsSortedArray()
        {
            int[] input = new int[] { 2, 3, 1 };
            int[] expected = new int[] { 1, 2, 3 };
            int[] actual = SelectionSort.Sort(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertionSort_GivenArrayOfManyElements_ReturnsSortedArray()
        {
            int[] input = new int[] { 2, 1, 8, 4, 55, 22, 0, 29, 11 };
            int[] expected = new int[] { 0, 1, 2, 4, 8, 11, 22, 29, 55 };
            int[] actual = SelectionSort.Sort(input);
            Assert.Equal(expected, actual);
        }
    }
}
