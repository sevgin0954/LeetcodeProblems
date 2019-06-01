using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(params int?[] values)
        {
            AddNodes(values);
        }

        private void AddNodes(int?[] values)
        {
            this.val = (int)values[0];

            var queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            var currentIndex = 1;
            while (currentIndex < values.Length)
            {
                var currentNode = queue.Dequeue();

                var currentValue = values[currentIndex];
                if (currentValue != null)
                {
                    currentNode.left = new TreeNode(values[currentIndex]);
                    queue.Enqueue(currentNode.left);
                }
                currentIndex++;
                if (currentIndex >= values.Length)
                {
                    break;
                }

                currentValue = values[currentIndex];
                if (currentValue != null)
                {
                    currentNode.right = new TreeNode(values[currentIndex]);
                    queue.Enqueue(currentNode.right);
                }
                currentIndex++;
                if (currentIndex >= values.Length)
                {
                    break;
                }
            }
        }
    }
}
