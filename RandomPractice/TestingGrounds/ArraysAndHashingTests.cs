using System;
using ArraysAndHasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace TestingGrounds
{
    [TestClass]
    public class ArraysAndHashingTests
    {
        [TestMethod]
        public void TestContainsDupWithDup()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 4 };

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

            Assert.AreEqual(true, ArraysAndHashing.IsAnagram(s, t));


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

        [TestMethod]
        public void TestTwoSums()
        {
            int[] array = { 2, 7, 11, 15 };

            int[] expectedAnswer = { 0, 1 };

            Assert.AreEqual(true, expectedAnswer.SequenceEqual(ArraysAndHashing.TwoSums(array, 9)));

            array = new int[] { 3, 2, 4 };

            expectedAnswer = new int[] { 1, 2 };

            Assert.AreEqual(true, expectedAnswer.SequenceEqual(ArraysAndHashing.TwoSums(array, 6)));
        }

        [TestMethod]
        public void TestGroupAnagrams()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            //List<IList<string>> expectedf = new List<IList<string>>(){ [["bat"], ["nat", "tan"], ["ate", "eat", "tea"}

            IList<IList<string>> result = ArraysAndHashing.GroupAnagrams(strs);
        }

        [TestMethod]
        public void TestTopKFrequent()
        {
            int[] array = { 1, 1, 1, 2, 2, 3 };
            int[] expected = { 1, 2 };

            Assert.AreEqual(true, expected.SequenceEqual(ArraysAndHashing.TopKFrequent(array, 2)));

            array = new int[] { 3, 0, 1, 0 };
            expected = new int[] { 0 };

            Assert.AreEqual(true, expected.SequenceEqual(ArraysAndHashing.TopKFrequent(array, 1)));


        }

        [TestMethod]
        public void TestIsValidSudoku()
        {
            char[][] board = new char[9][];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new char[9];
            }

            InitBoard(board, "53..7...9", "6..195...", ".98....6.", "8...6...3", "4..8.3..1", "7...2...6", ".6....28.", "...419..5", "....8..79");


            Debug.WriteLine("Request Board");
            PrintBoard(board);

            Assert.IsTrue(ArraysAndHashing.IsValidSudoku(board));

        }

        private static void InitBoard(char[][] board, params string[] rows)
        {
            for (int i = 0; i < rows.Length; i++)
            for (int j = 0; j < rows[i].Length; j++)
            {
                board[i][j] = rows[i][j];
            }
        }

        private static void PrintBoard(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {

                Debug.Write("[ ");
                for (int j = 0; j < board[i].Length; j++)
                {
                    Debug.Write(board[i][j]+" ");

                }

                Debug.Write("] \n");

            }

        }


    }
}