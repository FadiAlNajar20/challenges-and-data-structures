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
    }
}
