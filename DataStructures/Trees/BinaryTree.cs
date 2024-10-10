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

        public List<int> LargestValueEachLevel()
        {
            List<int> largestValues = new List<int>();
            if (Root == null) return largestValues;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node current = queue.Dequeue();
                    maxAtLevel = Math.Max(maxAtLevel, current.Value);

                    if (current.Left != null) queue.Enqueue(current.Left);
                    if (current.Right != null) queue.Enqueue(current.Right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }

        public void PrintRightView()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            PrintRightViewRecursive(Root, 0, -1);
        }

        private int PrintRightViewRecursive(Node node, int currentLevel, int maxLevel)
        {
            if (node == null)
            {
                return maxLevel;
            }

            if (currentLevel > maxLevel)
            {
                Console.WriteLine(node.Value);
                maxLevel = currentLevel;
            }

            maxLevel = PrintRightViewRecursive(node.Right, currentLevel + 1, maxLevel);
            maxLevel = PrintRightViewRecursive(node.Left, currentLevel + 1, maxLevel);

            return maxLevel;
        }

        public int FindMaxLevelNodes()
        {
            if (Root == null)
                return -1;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxNodes = 0;  
            int maxLevel = 0;  
            int currentLevel = 0;  

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;  

                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }

        public int FindMinimumDepth()
        {
            if (Root == null)
            {
                return 0;
            }

            Queue<(Node node, int depth)> queue = new Queue<(Node node, int depth)>();
            queue.Enqueue((Root, 1)); 

            while (queue.Count > 0)
            {
                var (currentNode, currentDepth) = queue.Dequeue();

                if (currentNode.Left == null && currentNode.Right == null)
                {
                    return currentDepth;
                }

                if (currentNode.Left != null)
                {
                    queue.Enqueue((currentNode.Left, currentDepth + 1));
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue((currentNode.Right, currentDepth + 1));
                }
            }

            return 0; 
        }

        private void CollectValues(Node node, List<int> values)
        {
            if (node == null) return;
            CollectValues(node.Left, values);
            values.Add(node.Value);
            CollectValues(node.Right, values);
        }

        private void AssignValues(Node node, Queue<int> values)
        {
            if (node == null) return;
            AssignValues(node.Left, values);
            node.Value = values.Dequeue();  // Replace node value with sorted values
            AssignValues(node.Right, values);
        }

        public void ConvertToBST()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            // Step 1: Collect all values from the tree
            List<int> values = new List<int>();
            CollectValues(Root, values);

            // Step 2: Sort the collected values
            values.Sort();

            // Step 3: Assign the sorted values back to the tree (in-order)
            Queue<int> sortedValues = new Queue<int>(values);  // Use Queue for ordered assignment
            AssignValues(Root, sortedValues);
        }
    }
}
