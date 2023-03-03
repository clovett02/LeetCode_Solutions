using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;


namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_LongestPalindromicSubstring
    {
        [TestMethod]
        public void Test_LongestPalindromicSubstring_Solution()
        {
            Assert.AreEqual("bob", LongestPalindromicSubstring.Solution("kabob"));
            Assert.AreEqual("babad", LongestPalindromicSubstring.Solution("bab"));
        }
        [TestMethod]
        public void Test_LongestPalindromicSubstring_ReturnSubstring()
        {
            Assert.AreEqual("abcde", LongestPalindromicSubstring.ReturnSubstring("abcde", 0, 4));
            Assert.AreEqual("abcde", LongestPalindromicSubstring.ReturnSubstring("abcdef", 0, 4));
            Assert.AreEqual("bcdef", LongestPalindromicSubstring.ReturnSubstring("abcdefg", 1, 5));
        }
        [TestMethod]
        public void Test_Palindromic()
        {
            Assert.AreEqual(true, LongestPalindromicSubstring.Palindromic("aba"));
            Assert.AreEqual(false, LongestPalindromicSubstring.Palindromic("abb"));
        }
    }
}
