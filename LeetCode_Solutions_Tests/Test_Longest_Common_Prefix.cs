using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_Longest_Common_Prefix
    {
        string[] testarray1 = {  "abc", "apple", "axe" };
        string[] testarray2 = { "black" };
        string[] testarray3 = { "blue", "purple" };
        string[] testarray4 = { "opal", "opiate", "opaque" };
        string[] testarray5 = { "", "" };
        string[] testarray6 = { "abc", "" };
        [TestMethod]
        public void Test_Solution()
        {   
            Assert.AreEqual( "a", Longest_Common_Prefix.Solution(testarray1));
            Assert.AreEqual( "black", Longest_Common_Prefix.Solution(testarray2));
            Assert.AreEqual( "", Longest_Common_Prefix.Solution(testarray3));
            Assert.AreEqual( "op", Longest_Common_Prefix.Solution(testarray4));
        }
        [TestMethod]
        public void Test_ShortestWord()
        {
            Assert.AreEqual(4, Longest_Common_Prefix.ShortestWord(testarray4));
            Assert.AreEqual(0, Longest_Common_Prefix.ShortestWord(testarray5));   
            Assert.AreEqual(0, Longest_Common_Prefix.ShortestWord(testarray6));
        }
    }
}