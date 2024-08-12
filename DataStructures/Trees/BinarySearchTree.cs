using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int data)
        {
            Root = AddRecursive(Root, data);
        }

        private Node AddRecursive(Node node, int data)
        {
            if (node == null)
            {
                return new Node(data);
            }

            if (data < node.Value)
            {
                node.Left = AddRecursive(node.Left, data);
            }
            else if (data > node.Value)
            {
                node.Right = AddRecursive(node.Right, data);
            }

            return node;
        }

        public bool Contains(int data)
        {
            return ContainsRecursive(Root, data);
        }

        private bool ContainsRecursive(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }

            if (data == node.Value)
            {
                return true;
            }

            return data < node.Value ? ContainsRecursive(node.Left, data) : ContainsRecursive(node.Right, data);
        }

        public void Remove(int data)
        {
            Root = RemoveRecursive(Root, data);
        }

        private Node RemoveRecursive(Node node, int data)
        {
            if (node == null) return null;

            if (data < node.Value)
            {
                node.Left = RemoveRecursive(node.Left, data);
            }
            else if (data > node.Value)
            {
                node.Right = RemoveRecursive(node.Right, data);
            }
            else
            {
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                node.Value = MinValue(node.Right);
                node.Right = RemoveRecursive(node.Right, node.Value);
            }
            return node;
        }

        private int MinValue(Node node)
        {
            int minv = node.Value;
            while (node.Left != null)
            {
                minv = node.Left.Value;
                node = node.Left;
            }
            return minv;
        }
    }

}
