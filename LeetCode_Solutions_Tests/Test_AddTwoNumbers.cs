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
        ListNode[] Nodes3;
        ListNode[] Nodes4;

        public void InitializeNodes(ref ListNode[] nodes, int NumberOfNodes)
        {
            nodes = new ListNode[NumberOfNodes];
            for (int i = 0; i < nodes.Length; i++)
            {
                if(i == 0)
                {
                    nodes[i] = new ListNode(i + 1);
                }
                else
                {
                    nodes[i] = new ListNode(i + 1, nodes[i - 1]);
                }
            }
        }
        public void InitializeNodesAtValue(ref ListNode[] nodes, int NumberOfNodes, int val)
        {
            nodes = new ListNode[NumberOfNodes];
            for (int i = 0; i < nodes.Length; i++)
            {
                if (i == 0)
                {
                    nodes[i] = new ListNode(val);
                }
                else
                {
                    nodes[i] = new ListNode(val, nodes[i - 1]);
                }
            }
        }
        [TestInitialize]
        public void Initialize()
        {
            InitializeNodes(ref Nodes1, 4);
            InitializeNodes(ref Nodes2, 4);
            InitializeNodesAtValue(ref Nodes3, 7, 9);
            InitializeNodesAtValue(ref Nodes4, 4, 9);
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
            ListNode result2 = AddTwoNumbers.AddNodes(Nodes1[Nodes1.Length - 1], Nodes2[Nodes2.Length - 1]);

            string answer = PrintResult(result);
            string answer2 = PrintResult(result2);
            Assert.IsTrue("8642" == answer);
            Assert.IsTrue("8642" == answer2);
        }
        [TestMethod]
        public void Test_Solution2()
        {
            ListNode result3 = AddTwoNumbers.AddNodes(Nodes3[Nodes3.Length - 1], Nodes4[Nodes4.Length - 1]);

            string answer3 = PrintResult(result3);
            Assert.IsTrue("89990001" == answer3);
        }
    }
}
