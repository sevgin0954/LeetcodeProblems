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

    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var nodes = GetNodesAsList(head);

        if (nodes.Count == 1)
        {
            return null;
        }

        var NthNodeIndex = nodes.Count - n;
        if (n == nodes.Count)
        {
            head = head.next;
        }
        else if (n == 1)
        {
            nodes[NthNodeIndex - 1].next = null;
        }
        else
        {
            var prevNode = nodes[NthNodeIndex - 1];
            var nextNode = nodes[NthNodeIndex + 1];
            prevNode.next = nextNode;
        }

        return head;
    }

    private static IList<ListNode> GetNodesAsList(ListNode head)
    {
        var nodes = new List<ListNode>();

        var currentNode = head;
        while (currentNode != null)
        {
            nodes.Add(currentNode);
            currentNode = currentNode.next;
        }

        return nodes;
    }
}