
namespace BasicArraysTest
{
    [TestClass]
    public class BasicArrayTests
    {
        [TestMethod]
        public void TestFindMaxConsecutiveOnes()
        {
            int[] array = { 1, 1, 0, 1, 1, 1, 0 };

            Assert.AreEqual(3, BasicArrays.BasicArrays.FindMaxConsecutiveOnes(array));


        }

        [TestMethod]
        public void TestNumbersWithEvenDigits()
        {
            int[] array = { 12, 345, 2, 6, 7896 };

            Assert.AreEqual(2, BasicArrays.BasicArrays.FindNumbers(array));

        }

        [TestMethod]
        public void TestSortedSquares()
        {
            int[] array = { -4, -1, 0, 3, 10 };

            Assert.AreEqual(2, BasicArrays.BasicArrays.SortedSquares(array));

        }

        

        [TestMethod]
        public void TestDuplicateZeros()
        {
            int[] array = { 1,0,2,3,0,4,5,0 };

            int[] result = BasicArrays.BasicArrays.DuplicateZeros(array);

            Assert.AreEqual(true, result.SequenceEqual(new int[] { 1, 0, 0, 2, 3, 0, 0, 4 }));

        }

        [TestMethod]
        public void TestMerge()
        {
            int[] array1 = { 1, 2, 3, 0, 0, 0 };

            int m = 3;

            int n = 3;

            int[] array2 = { 2, 5, 6 };

            int[] mergedResult = BasicArrays.BasicArrays.Merge(array1, m , array2, n);

            Assert.AreEqual(true, mergedResult.SequenceEqual(new int[] { 1, 2, 2, 3, 5, 6 }));

        }
    }
}