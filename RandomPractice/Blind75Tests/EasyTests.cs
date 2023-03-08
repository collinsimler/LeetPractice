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
    }
}