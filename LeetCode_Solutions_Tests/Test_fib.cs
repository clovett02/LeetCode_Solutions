using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;


namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_fib
    {
        [TestMethod]
        public void Test_fib_Solution()
        {
            Assert.AreEqual(1, fib.solution(1));
            Assert.AreEqual(1, fib.solution(2));
            Assert.AreEqual(2, fib.solution(3));
            Assert.AreEqual(3, fib.solution(4));
            Assert.AreEqual(5, fib.solution(5));
            Assert.AreEqual(8, fib.solution(6));
            Assert.AreEqual(13, fib.solution(7));
            Assert.AreEqual(21, fib.solution(8));
            System.Console.WriteLine(fib.solution(15));
        }
    }
}