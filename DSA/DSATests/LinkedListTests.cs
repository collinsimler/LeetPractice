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
            SinglyLinkedList.ListNode head = new SinglyLinkedList.ListNode(1);

            // Act
            SinglyLinkedList.ListNode result = SinglyLinkedList.ReverseList(head);

            // Assert
            Assert.AreEqual(head, result);
        }

        [TestMethod]
        public void ReverseList_WithMultipleNodes_ShouldReverseLinkedList()
        {
            // Arrange
            SinglyLinkedList.ListNode head = new SinglyLinkedList.ListNode(1);
            head.next = new SinglyLinkedList.ListNode(2);
            head.next.next = new SinglyLinkedList.ListNode(3);
            head.next.next.next = new SinglyLinkedList.ListNode(4);
            head.next.next.next.next = new SinglyLinkedList.ListNode(5);

            // Act
            SinglyLinkedList.ListNode result = SinglyLinkedList.ReverseList(head);

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