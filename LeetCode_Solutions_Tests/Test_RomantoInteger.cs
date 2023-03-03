using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_RomantoInteger
    {
        [TestMethod]
        public void Test_RomantoInteger_Solution()
        {
            Assert.AreEqual(1, RomantoInteger.solution("I"));
            Assert.AreEqual(2, RomantoInteger.solution("II"));
            Assert.AreEqual(4, RomantoInteger.solution("IV"));
        }
        [TestMethod]
        public void Test_RomantoInteger_ReturnNumberforChar()
        {
            Assert.AreEqual(1, RomantoInteger.ReturnNumberforChar('I'));
            Assert.AreEqual(5, RomantoInteger.ReturnNumberforChar('V'));
        }
    }
    
}