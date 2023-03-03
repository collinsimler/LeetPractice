using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA;

namespace DSATests
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void TestRemoveDups()
        {
            int[] case1 = { 1, 2, 2, 3, 5, 7, 7, 8 };

            int newLength = Arrays.RemoveDuplicates(case1);

            int[] expected1 = { 1, 2, 3, 5, 7, 8 };

            Assert.IsTrue(expected1.Length == newLength);

            for (int i = 0; i < newLength; i++)
            {
                Assert.IsTrue(case1[i] == expected1[i]);
            }

           
        }
    }
}