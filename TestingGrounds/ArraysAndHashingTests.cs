using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraysAndHasing;
using System.Collections.Generic;

namespace TestingGrounds
{
    [TestClass]
    public class ArraysAndHashingTests
    {
        [TestMethod]
        public void TestContainsDupWithDup()
        {
            int[] nums = new int[] {1,2,3,4,4};

            Assert.AreEqual(true, ArraysAndHashing.ContainsDuplicate(nums));


        }

        [TestMethod]
        public void TestContainsDupWithoutDup()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, ArraysAndHashing.ContainsDuplicate(nums));


        }

        [TestMethod]
        public void TestIsAnagram()
        {
            string s = "anagram";
            string t = "nagaram";

            Assert.AreEqual(true, ArraysAndHashing.IsAnagram(s,t));


        }

        [TestMethod]
        public void TestIsNotAnagram()
        {
            string s = "anagram";
            string t = "rack";

            Assert.AreEqual(false, ArraysAndHashing.IsAnagram(s, t));


        }

        [TestMethod]
        public void TestIsNotAnagram2()
        {
            string s = "anagram";
            string t = "angrana";

            Assert.AreEqual(false, ArraysAndHashing.IsAnagramSortMethod(s, t));


        }
    }
}