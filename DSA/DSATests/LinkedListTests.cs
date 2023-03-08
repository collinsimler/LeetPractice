using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA.LinkedList;

namespace DSATests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestSingleLinkedList()
        {
            ListNode head = new ListNode();
            ListNode curr = head;

            for (int i = 0; i < 6; i++)
            {
                var temp = new ListNode();
                temp.val = i;

                curr.next = temp;
                curr = curr.next;
            }

            Console.WriteLine("This is the node List going in.");
            printAllNodes(head);

            head = SinglyLinkedList.ReverseList(head);

            Console.WriteLine("This is the node List coming out.");

            printAllNodes(head);


        }

        private void printAllNodes(ListNode head)
        {
            ListNode current = head;
            Debug.Write("[ ");
            while (current != null)
            {
                Debug.Write(current.val + ", ");
                current = current.next;
            }
            Debug.Write("]");
        }
    }
}