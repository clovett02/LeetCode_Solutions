using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;


namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_Fib
    {
        [TestMethod]
        public void Test_fib_Solution()
        {
            Assert.AreEqual(1, Fib.solution(1));
            Assert.AreEqual(1, Fib.solution(2));
            Assert.AreEqual(2, Fib.solution(3));
            Assert.AreEqual(3, Fib.solution(4));
            Assert.AreEqual(5, Fib.solution(5));
            Assert.AreEqual(8, Fib.solution(6));
            Assert.AreEqual(13, Fib.solution(7));
            Assert.AreEqual(21, Fib.solution(8));
            System.Console.WriteLine(Fib.solution(15));
        }
    }
}