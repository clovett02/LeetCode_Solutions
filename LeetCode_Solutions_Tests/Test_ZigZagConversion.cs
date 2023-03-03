using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_ZigZagConversion
    {
        [TestMethod]
        public void Test_ZigZagConversion_Solution()
        {
            ZigZagConversion zigzag = new ZigZagConversion();

            Assert.AreEqual("pahnplsiigyir", zigzag.Solution("paypalishiring", 3));
        }
    }
}