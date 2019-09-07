using Common;
using System;

public class Solution
{
    public static void Main()
    {
        var num1Root = new ListNode(1, 8);
        var num2Root = new ListNode(0);

        Console.WriteLine(AddTwoNumbers(num1Root, num2Root));
    }

    public static ListNode AddTwoNumbers(ListNode num1Head, ListNode num2Root)
    {
        var resultHead = new ListNode(0);

        var currentNum1Node = num1Head;
        var currentNum2Node = num2Root;
        var currentResultNode = resultHead;
        var left = 0;
        while (currentNum1Node != null && currentNum2Node != null)
        {
            var currentSum = currentNum1Node.val + currentNum2Node.val + left;
            var currentDigit = GegLastDigit(currentSum);
            left = CalculateLeft(currentSum);

            currentResultNode.next = new ListNode(currentDigit);

            currentResultNode = currentResultNode.next;
            currentNum1Node = currentNum1Node.next;
            currentNum2Node = currentNum2Node.next;
        }

        while (currentNum1Node != null)
        {
            left = CalculateCurrentDigitAndReturnLeft(currentNum1Node, currentResultNode, left);

            currentResultNode = currentResultNode.next;
            currentNum1Node = currentNum1Node.next;
        }

        while (currentNum2Node != null)
        {
            left = CalculateCurrentDigitAndReturnLeft(currentNum2Node, currentResultNode, left);

            currentResultNode = currentResultNode.next;
            currentNum2Node = currentNum2Node.next;
        }

        while (left > 0)
        {
            var currentDigit = GegLastDigit(left);
            left = CalculateLeft(left);

            currentResultNode.next = new ListNode(currentDigit);
            currentResultNode = currentResultNode.next;
        }

        return resultHead.next;
    }

    private static int CalculateCurrentDigitAndReturnLeft(ListNode numHead, ListNode resultNode, int left)
    {
        var currentSum = numHead.val + left;
        var currentDigit = GegLastDigit(currentSum);
        resultNode.next = new ListNode(currentDigit);

        left = CalculateLeft(currentSum);
        return left;
    }

    private static int GegLastDigit(int sum)
    {
        return sum % 10;
    }

    private static int CalculateLeft(int sum)
    {
        return (int)(sum / 10);
    }
}