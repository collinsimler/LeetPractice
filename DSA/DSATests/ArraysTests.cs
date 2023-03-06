using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays.DSA;

namespace DSATests
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void TestRemoveDups()
        {
            
            int[] testCase = { 1, 2, 2, 3, 5, 7, 7, 8 };
            
            int[] expectedSolution = { 1, 2, 3, 5, 7, 8 };

            TestDupsCase(testCase, expectedSolution);

            testCase = new int[] { 1, 1, 2 };

            expectedSolution = new int[] { 1, 2 };

            TestDupsCase(testCase, expectedSolution);

            testCase = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            expectedSolution = new int[] { 0, 1, 2, 3, 4 };

            TestDupsCase(testCase, expectedSolution);
            
        }

        private void TestDupsCase(int[] testCase, int[] expectedSolution)
        {
            int newLength = Array.RemoveDuplicates(testCase);

            Assert.IsTrue(expectedSolution.Length == newLength);

            for (int i = 0; i < newLength; i++)
            {
                Assert.IsTrue(testCase[i] == expectedSolution[i]);
            }
        }

        private void TestDupsCase2(int[] testCase, int[] expectedSolution)
        {
            int newLength = Array.RemoveDuplicates2(testCase);

            Assert.IsTrue(expectedSolution.Length == newLength);

            for (int i = 0; i < newLength; i++)
            {
                Assert.IsTrue(testCase[i] == expectedSolution[i]);
            }
        }

        [TestMethod]
        public void TestRemoveDups2()
        {
            int[] testCase = { 1, 2, 2, 3, 5, 7, 7, 8 };

            int[] expectedSolution = { 1, 2, 3, 5, 7, 8 };

            TestDupsCase2(testCase, expectedSolution);

            testCase = new int[] { 1, 1, 2 };

            expectedSolution = new int[] { 1, 2 };

            TestDupsCase2(testCase, expectedSolution);

            testCase = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            expectedSolution = new int[] { 0, 1, 2, 3, 4 };

            TestDupsCase2(testCase, expectedSolution);
        }

        [TestMethod]
        public void TestRemoveValue()
        {

            int[] case1 = { 3,2,2,3 };

            int newLength = Array.RemoveElement(case1,3);

            int[] expected1 = {  2, 2 };

            Assert.IsTrue(expected1.Length == newLength);

            for (int i = 0; i < newLength; i++)
            {
                Assert.IsTrue(case1[i] == expected1[i]);
            }
        }

        [TestMethod]
        public void TestConCatenationOfArrays()
        {
            int[] case1 = { 1,2,1 };

            int[] result = Array.GetConcatenation(case1);

            int[] expected1 = { 1, 2, 1, 1, 2, 1 };


            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(expected1[i] == result[i]);
            }

        }
    }
}