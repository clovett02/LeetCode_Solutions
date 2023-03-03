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
            LongestPalindromicSubstring Palindrome = new LongestPalindromicSubstring();
            Assert.AreEqual("bob", Palindrome.Solution("kabob"));
            Assert.AreEqual("bab", Palindrome.Solution("babad"));
            Assert.AreEqual("baaaaaaab", Palindrome.Solution("dcbaaaaaaabd"));
            Assert.AreEqual("bb", Palindrome.Solution("bb"));
            Assert.AreEqual("bb", Palindrome.Solution("abb"));
        }
        [TestMethod]
        public void Test_LongestPalindromicSubstring_ReturnSubstring()
        {
            LongestPalindromicSubstring Palindrome = new LongestPalindromicSubstring();
            Assert.AreEqual("abcde", Palindrome.ReturnSubstring("abcde", 0, 4));
            Assert.AreEqual("abcde", Palindrome.ReturnSubstring("abcdef", 0, 4));
            Assert.AreEqual("bcdef", Palindrome.ReturnSubstring("abcdefg", 1, 5));
        }
        [TestMethod]
        public void Test_Palindromic()
        {
            LongestPalindromicSubstring Palindrome = new LongestPalindromicSubstring();
            Assert.AreEqual(true, Palindrome.Palindromic("aba"));
            Assert.AreEqual(false, Palindrome.Palindromic("abb"));
        }
    }
}
