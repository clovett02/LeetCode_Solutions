using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;
using System.Collections.Generic;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_DollarConverter
    {
        [TestMethod]
        public void Test_ConvertToDecimal()
        {
            decimal? result = DollarConverter.ConvertToDecimal("21.52");
            decimal answer = System.Convert.ToDecimal(21.52);
            Assert.AreEqual(answer, result);

            
        }
        [TestMethod]
        public void Test_ConvertToDecimal1()
        {
            decimal? result = DollarConverter.ConvertToDecimal("21.52.51");
            Assert.AreEqual(null, result);
        }
        [TestMethod]
        public void Test_Convert()
        {
            List<string> nums = new List<string>();
            nums.Add("21.52");
            nums.Add("21.52.51");

            List<decimal?> result = DollarConverter.Convert(nums);
            decimal answer1 = System.Convert.ToDecimal(21.52);
            Assert.AreEqual(answer1, result[0]);
            Assert.AreEqual(null, result[1]);
        }
    }
}