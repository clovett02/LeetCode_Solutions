using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_ZigZagConversion
    {
        ZigZagConversion zigzag = new ZigZagConversion();
        public Test_ZigZagConversion()
        {

        }
        [TestMethod]
        public void Test_ZigZagConversion_Solution()
        {
            // Assert.AreEqual("pahnaplsiigyir", zigzag.Solution("paypalishiring", 3));
        }
        [TestMethod]
        public void Test_ZigZagConversion_ReturnNumberofColumns()
        {
            Assert.AreEqual(2, zigzag.ReturnNumberofColumns("abc", 2));
            Assert.AreEqual(3, zigzag.ReturnNumberofColumns("abcde", 2));
            Assert.AreEqual(2, zigzag.ReturnNumberofColumns("abcde", 4));
            Assert.AreEqual(1, zigzag.ReturnNumberofColumns("abcde", 5));
            Assert.AreEqual(5, zigzag.ReturnNumberofColumns("abcde", 1));
            Assert.AreEqual(1, zigzag.ReturnNumberofColumns("abcdef", 7));
            Assert.AreEqual(1, zigzag.ReturnNumberofColumns("abcdefg", 7));
            Assert.AreEqual(2, zigzag.ReturnNumberofColumns("abcdefgh", 7));
            Assert.AreEqual(3, zigzag.ReturnNumberofColumns("abcdefghi", 7));
        }
    }
}