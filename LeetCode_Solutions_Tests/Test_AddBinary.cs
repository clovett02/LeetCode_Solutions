using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_AddBinary
    {
        [TestMethod]
        public void Test1()
        {
            AddBinary obj = new AddBinary();
            string answer = obj.Solution("1", "1");
        }
    }
}
