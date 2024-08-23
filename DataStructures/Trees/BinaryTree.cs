namespace challenges_and_data_structures
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        // PreOrder Traversal (Root, Left, Right)
        public void PreOrder(Node node, Action<int> callback)
        {
            if (node == null) return;
            callback(node.Value);
            PreOrder(node.Left, callback);
            PreOrder(node.Right, callback);
        }

        // InOrder Traversal (Left, Root, Right)
        public void InOrder(Node node, Action<int> callback)
        {
            if (node == null) return;
            InOrder(node.Left, callback);
            callback(node.Value);
            InOrder(node.Right, callback);
        }

        // PostOrder Traversal (Left, Right, Root)
        public void PostOrder(Node node, Action<int> callback)
        {
            if (node == null) return;
            PostOrder(node.Left, callback);
            PostOrder(node.Right, callback);
            callback(node.Value);
        }

        // Print Tree
        public void Print(Node node, string indent = "", bool isLeft = true)
        {
            if (node == null)
            {
                Console.WriteLine($"{indent}*");
                return;
            }

            Console.WriteLine($"{indent}{(isLeft ? "├──" : "└──")}{node.Value}");
            indent += isLeft ? "│   " : "    ";
            Print(node.Left, indent, true);
            Print(node.Right, indent, false);
        }
        public void MirrorTree(Node node)
        {
            if (node == null) return;

            MirrorTree(node.Left);
            MirrorTree(node.Right);

            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        public List<int> InorderTraversal(Node node)
        {
            List<int> result = new List<int>();
            if (node != null)
            {
                result.AddRange(InorderTraversal(node.Left));
                result.Add(node.Value);
                result.AddRange(InorderTraversal(node.Right));
            }
            return result;
        }

        public void Mirror()
        {
            MirrorTree(Root);
        }

        public List<int> InorderTraversal()
        {
            return InorderTraversal(Root);
        }

        public int FindSecondMax()
        {
            if (Root == null)
                throw new InvalidOperationException("The tree is Empty");

            int? max = null;
            int? secondMax = null;
            FindSecondMaxHelper(Root, ref max, ref secondMax);

            if (secondMax == null)
                throw new InvalidOperationException("The tree does not contain two distinct values.");

            return secondMax.Value;
        }

        private void FindSecondMaxHelper(Node node, ref int? max, ref int? secondMax)
        {
            if (node == null)
                return;

            if (max == null || node.Value > max)
            {
                secondMax = max;
                max = node.Value;
            }
            else if ((secondMax == null || node.Value > secondMax) && node.Value < max)
            {
                secondMax = node.Value;
            }

            FindSecondMaxHelper(node.Left, ref max, ref secondMax);
            FindSecondMaxHelper(node.Right, ref max, ref secondMax);
        }
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Value;

            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }
    }
}
