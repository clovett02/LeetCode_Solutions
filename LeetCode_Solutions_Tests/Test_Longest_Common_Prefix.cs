using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_Longest_Common_Prefix
    {
        [TestMethod]
        public void Test_Longest_Common_Prefix_Solution()
        {
            string[] testarray1 = {
                "abc", "apple", "axe"
            };
            Assert.AreEqual("a", Longest_Common_Prefix.Solution(testarray1));
        }
    }
}