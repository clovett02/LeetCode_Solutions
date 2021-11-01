using System;

namespace LeetCode_Solutions
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoNumbers
    {
        public static string ReturnNodesAsString(ListNode node)
        {
            string result = "";
            ListNode LocalNode = node;
            while (LocalNode != null)
            {
                result += LocalNode.val.ToString();
                LocalNode = LocalNode.next;
            }
            return result;
        }
        public static ListNode ReturnStringAsNodeInReverse(string word)
        {
            ListNode[] nodes = new ListNode[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                if(i == 0) { nodes[i] = new ListNode(Convert.ToInt32(word.Substring(i, 1))); }
                else { nodes[i] = new ListNode(Convert.ToInt32(word.Substring(i, 1)), nodes[i - 1]); }
            }
            return nodes[word.Length - 1];
        }
        public static string ReturnReverseofString(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word.Substring(i, 1);
            }
            return result;
        }
        public ListNode OldSolution(ListNode l1, ListNode l2)
        {
            string num1String = ReturnNodesAsString(l1);
            string num2String = ReturnNodesAsString(l2);
            num1String = ReturnReverseofString(num1String);
            num2String = ReturnReverseofString(num2String);
            long intresult = Convert.ToInt64(num1String) + Convert.ToInt64(num2String);
            string stringresult = intresult.ToString();
            ListNode result = ReturnStringAsNodeInReverse(stringresult);
            return result;
        }
        public static int ReturnNumberOfNodes(ListNode node)
        {
            int result = 0;
            while (node != null)
            {
                result++;
                node = node.next;
            }
            return result;
        }
        public static ListNode ReturnLinkedListInReverse(ListNode node)
        {
            
        }
        public ListNode Solution(ListNode l1, ListNode l2)
        {

        }
    }
}