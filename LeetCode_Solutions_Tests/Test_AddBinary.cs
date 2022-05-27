using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_AddBinary
    {
        [TestMethod]
        public void Test_Solution()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("1", "1");
        }
        [TestMethod]
        public void Test_ReverseString()
        {
            string answer = AddBinary.ReverseString("edcba");
            Assert.AreEqual("abcde", answer);
        }
    }
}
