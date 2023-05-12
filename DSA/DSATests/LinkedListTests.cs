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
        public void ReverseList_WithSingleNode_ShouldReturnSameNode()
        {
            // Arrange
            ListNode head = new ListNode(1);

            // Act
            ListNode result = SinglyLinkedList.ReverseList(head);

            // Assert
            Assert.AreEqual(head, result);
        }

        [TestMethod]
        public void ReverseList_WithMultipleNodes_ShouldReverseLinkedList()
        {
            // Arrange
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            // Act
            ListNode result = SinglyLinkedList.ReverseList(head);

            // Assert
            Assert.AreEqual(5, result.val);
            Assert.AreEqual(4, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(1, result.next.next.next.next.val);
            Assert.IsNull(result.next.next.next.next.next);
        }
    }
}