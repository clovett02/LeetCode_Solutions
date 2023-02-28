using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_RomantoInteger
    {
        public void Test_RomanetoInteger_Solution()
        {
            Assert.AreEqual(RomantoInteger.solution("I"), 1);
            Assert.AreEqual(RomantoInteger.solution("II"), 2);
        }
    }
    
}