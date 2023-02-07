using System.Runtime.Intrinsics.X86;
using BasicArrays;


namespace BasicArraysTest
{
    [TestClass]
    public class BasicArrayTests
    {
        [TestMethod]
        public void TestFindMaxConsecutiveOnes()
        {
            int[] array = { 1, 1, 0, 1, 1, 1, 0 };

            Assert.AreEqual(3, Insertion.FindMaxConsecutiveOnes(array));


        }

        [TestMethod]
        public void TestNumbersWithEvenDigits()
        {
            int[] array = { 12, 345, 2, 6, 7896 };

            Assert.AreEqual(2, Insertion.FindNumbers(array));

        }

        [TestMethod]
        public void TestSortedSquares()
        {
            int[] array = { -4, -1, 0, 3, 10 };

            Assert.AreEqual(2, Insertion.SortedSquares(array));

        }

        

        [TestMethod]
        public void TestDuplicateZeros()
        {
            int[] array = { 1,0,2,3,0,4,5,0 };

            int[] result = Insertion.DuplicateZeros(array);

            Assert.AreEqual(true, result.SequenceEqual(new int[] { 1, 0, 0, 2, 3, 0, 0, 4 }));

        }

        [TestMethod]
        public void TestMerge()
        {
            int[] array1 = { 1, 2, 3, 0, 0, 0 };

            int m = 3;

            int n = 3;

            int[] array2 = { 2, 5, 6 };

            int[] mergedResult = Insertion.Merge(array1, m , array2, n);

            Assert.AreEqual(true, mergedResult.SequenceEqual(new int[] { 1, 2, 2, 3, 5, 6 }));

        }

        [TestMethod]
        public void TestRemoveAllElements()
        {
            int[] array = { 1, 2, 4, 7, 7, 5, 3, 5, 2, 1 };

            Assert.AreEqual(8, Deletion.RemoveAllElements(array, 2));

            array = new int[] { 3, 2, 2, 3 };

            Assert.AreEqual(2, Deletion.RemoveAllElements(array, 3));




        }

        [TestMethod]
        public void TestCheckPairExists()
        {
            int[] array = { 10, 2, 5, 3 };

            Assert.IsTrue(Search.CheckPairExists(array));

            array = new int[] { 3, 1, 7, 11 };

            Assert.IsFalse(Search.CheckPairExists(array));


        }

        [TestMethod]
        public void TestVaildMountainArray()
        {
            int[] array = { 2, 4, 6, 5, 4, 3, 2 };

            Assert.IsTrue(Search.ValidMountainArray(array));

            array = new int[] { 2, 4, 7, 5, 4, 3, 2 };

            Assert.IsFalse(Search.ValidMountainArray(array));


            array = new int[] { 2, 4, 6, 5, 4, 2, 1 };

            Assert.IsFalse(Search.ValidMountainArray(array));

        }
    }
}