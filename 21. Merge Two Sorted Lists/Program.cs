using Common;
using System;

class Program
{
    static void Main()
    {
        var l1Head = new ListNode(1, 2, 4);
        var l2Head = new ListNode(1, 3, 4);
        Console.WriteLine(MergeTwoLists(l1Head, l2Head));
    }

    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var dummyNodeHead = new ListNode(0);
        var currentL1Node = l1;
        var currentL2Node = l2;
        var currentMergedList = dummyNodeHead;

        while (currentL1Node != null && currentL2Node != null)
        {
            if (currentL1Node.val > currentL2Node.val)
            {
                currentMergedList.next = new ListNode(currentL2Node.val);

                currentMergedList = currentMergedList.next;
                currentL2Node = currentL2Node.next;
            }
            else if (currentL1Node.val < currentL2Node.val)
            {
                currentMergedList.next = new ListNode(currentL1Node.val);

                currentMergedList = currentMergedList.next;
                currentL1Node = currentL1Node.next;
            }
            else if (currentL1Node.val == currentL2Node.val)
            {
                currentMergedList.next = new ListNode(currentL1Node.val);
                currentMergedList = currentMergedList.next;

                currentMergedList.next = new ListNode(currentL2Node.val);
                currentMergedList = currentMergedList.next;

                currentL1Node = currentL1Node.next;
                currentL2Node = currentL2Node.next;
            }
        }

        if (currentL1Node != null)
        {
            currentMergedList.next = currentL1Node;
        }
        if (currentL2Node != null)
        {
            currentMergedList.next = currentL2Node;
        }

        return dummyNodeHead.next;
    }
}