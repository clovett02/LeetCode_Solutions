using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_AddBinary
    {
        [TestMethod]
        public void Test_AddBinary_Solution_1and1()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("1", "1");
            Assert.AreEqual("10", answer);
        }
        [TestMethod]
        public void Test_AddBinary_Solution_10and01()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("10", "01");
            Assert.AreEqual("11", answer);
        }
        [TestMethod]
        public void Test__AddBinary_Solution_101and011()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("101", "011");
            Assert.AreEqual("1000", answer);
        }
        [TestMethod]
        public void Test__AddBinary_Solution_11and1()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("11", "1");
            Assert.AreEqual("100", answer);
        }
        [TestMethod]
        public void Test__AddBinary_Solution_1010and1011()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("1010", "1011");
            Assert.AreEqual("10101", answer);
        }
        [TestMethod]
        public void Test__AddBinary_Solution_101111and10()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("101111", "10");
            Assert.AreEqual("110001", answer);
        }
        [TestMethod]
        public void Test__AddBinary_ReverseString()
        {
            string answer = AddBinary.ReverseString("edcba");
            Assert.AreEqual("abcde", answer);
        }
    }
}
