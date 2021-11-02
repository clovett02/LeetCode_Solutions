using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Solutions;
using System;

namespace LeetCode_Solutions_Tests
{
    [TestClass]
    public class Test_AddTwoNumbers
    {
        ListNode[] Nodes1;
        ListNode[] Nodes2;
        [TestInitialize]
        public void Initialize()
        {
            Nodes1 = new ListNode[4];
            Nodes2 = new ListNode[4];

            for (int i = 0; i < Nodes1.Length; i++)
            {
                if(i == 0)
                {
                    Nodes1[i] = new ListNode(i + 1);
                    Nodes2[i] = new ListNode(i + 1);
                }
                else
                {
                    Nodes1[i] = new ListNode(i + 1, Nodes1[i - 1]);
                    Nodes2[i] = new ListNode(i + 1, Nodes2[i - 1]);
                }
                
            }
        }
        [TestMethod]
        public void Test_ListNode()
        {
            ListNode node2 = new ListNode(3);
            ListNode node1 = new ListNode(1, node2);
            ListNode node = node1;

            string result = "";

            while(node != null)
            {
                Console.Write(node.val);
                result += node.val.ToString();
                node = node.next;
            }

            Assert.IsTrue("13" == result);
        }
        [TestMethod]
        public void Test_ReturnReverseofString()
        {
            
            string word = "abc";
            Assert.IsTrue("cba" == AddTwoNumbers.ReturnReverseofString(word));
        }
        [TestMethod]
        public void Test_ReturnNumOfNodes()
        {
            int result = AddTwoNumbers.ReturnNumberOfNodes(Nodes1[3]);
            Assert.AreEqual(4, result);
        }
        public string PrintResult(ListNode node)
        {
            string result = "";
            while(node != null)
            {
                Console.Write(node.val);
                result += node.val;
                node = node.next;
            }
            return result;
        }
        [TestMethod]
        public void Test_Solution()
        {
            AddTwoNumbers funcCaller = new AddTwoNumbers();
            ListNode result = funcCaller.OldSolution(Nodes1[Nodes1.Length - 1], Nodes2[Nodes2.Length - 1]);
            
            string answer = PrintResult(result);
            Assert.IsTrue("8642" == answer);
        }
    }
}
