using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_RomantoInteger
    {
        [TestMethod]
        public void Test_RomanetoInteger_Solution()
        {
            Assert.AreEqual(1, RomantoInteger.solution("I"));
            Assert.AreEqual(2, RomantoInteger.solution("II"));
        }
    }
    
}