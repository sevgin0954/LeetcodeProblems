using System;
using System.Collections.Generic;
using Common;

class Program
{
    static void Main()
    {
        //var head = new ListNode(1, 2, 3, 4, 5);
        var head = new ListNode(0, 1);
        var n = 1;
        Console.WriteLine(RemoveNthFromEnd(head, n));
    }

    public static ListNode RemoveNthFromEnd(ListNode root, int n)
    {
        var currentNode = root;
        var nodes = new List<ListNode>();
        while (currentNode != null)
        {
            nodes.Add(currentNode);
            currentNode = currentNode.next;
        }

        var nthNodeIndex = nodes.Count - n;
        var nthNode = nodes[nthNodeIndex];
        var nthNodeNext = nthNode.next;
        if (nthNodeIndex == 0)
        {
            if (nthNodeNext == null)
            {
                return null;
            }

            return nthNodeNext;
        }

        var nthNodePrev = nodes[nthNodeIndex - 1];
        nthNodePrev.next = nthNodeNext;

        return root;
    }
}