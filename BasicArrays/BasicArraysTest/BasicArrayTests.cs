
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
    }
}