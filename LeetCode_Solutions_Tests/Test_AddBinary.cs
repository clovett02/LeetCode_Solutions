using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_AddBinary
    {
        [TestMethod]
        public void Test_Solution_1and1()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("1", "1");
            Assert.AreEqual("10", answer);
        }
        [TestMethod]
        public void Test_Solution_10and01()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("10", "01");
            Assert.AreEqual("11", answer);
        }
        [TestMethod]
        public void Test_Solution_101and011()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("101", "011");
            Assert.AreEqual("1000", answer);
        }
        [TestMethod]
        public void Test_ReverseString()
        {
            string answer = AddBinary.ReverseString("edcba");
            Assert.AreEqual("abcde", answer);
        }
    }
}
