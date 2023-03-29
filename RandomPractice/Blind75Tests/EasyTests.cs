using Blind75;

namespace Blind75Tests
{
    [TestClass]
    public class EasyTests
    {
        [TestMethod]
        public void TestMissingNumber()
        {
            int[] case0 = new[] { 3, 0, 1 };
            
            Assert.AreEqual(2, Easy.MissingNumber(case0));

            case0 = new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Assert.AreEqual(8, Easy.MissingNumber(case0));

        }

        [TestMethod]
        public void TestContainsDuplicate()
        {
            int[] testCase = new[] { 1, 2, 3, 1 };

            Assert.IsTrue(Easy.ContainsDuplicate(testCase));

            testCase = new[] { 1, 2, 3, 4 };

            Assert.IsFalse(Easy.ContainsDuplicate(testCase));

        }


        [TestMethod]
        public void TestIsAnagram()
        {
            string word = "worddog";
            string possibleAnagram = "goddrow";

            Assert.IsTrue(Easy.IsAnagram(word,possibleAnagram));

            word = "idontknow";
            possibleAnagram = "notidk";

            Assert.IsFalse(Easy.IsAnagram(word,possibleAnagram));

        }

        [TestMethod]
        public void TestTwoSum()
        {
            int[] testCase = new[] { 2, 7, 11, 15 };
            int target = 9;

            Assert.AreEqual(new int[]{0,1},Easy.TwoSum(testCase,target));

            testCase = new[] { 3, 2, 4 };
            target = 6;

            Assert.AreEqual(new int[]{0,1},Easy.TwoSum(testCase,target));

        }

        [TestMethod]
        public void TestIsAnagram()
        {
            string word = "worddog";
            string possibleAnagram = "goddrow";

            Assert.IsTrue(Easy.IsAnagram(word, possibleAnagram));

            word = "idontknow";
            possibleAnagram = "notidk";

            Assert.IsFalse(Easy.IsAnagram(word, possibleAnagram));

        }
    }
}