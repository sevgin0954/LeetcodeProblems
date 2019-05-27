using Common;
using System;

class Program
{
    static void Main()
    {
        var linkedList = new ListNode(1, 2, 3, 4);
        var swapedNodesLinkedList = SwapPairs(linkedList);
        Console.WriteLine(swapedNodesLinkedList);
    }

    public static ListNode SwapPairs(ListNode head)
    {
        var currentNode = head;
        while (currentNode != null && currentNode.next != null)
        {
            var nextNode = currentNode.next;
            var currentNodeValue = currentNode.val;
            currentNode.val = nextNode.val;
            nextNode.val = currentNodeValue;

            currentNode = nextNode.next;
        }

        return head;
    }
}