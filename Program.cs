using challenges_and_data_structures;
using challenges_and_data_structures.DataStructures.LinkedList;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace challenges_and_data_structuresx
{
    public class Program
    {
        static void Main(string[] args)
        {

            BinaryTree Btree1 = new BinaryTree();
            Btree1.Root = new Node(1);
            Btree1.Root.Left = new Node(2);
            Btree1.Root.Right = new Node(3);
            Btree1.Root.Left.Left = new Node(4);
            Btree1.Root.Left.Right = new Node(5);

            int minDepth1 = Btree1.FindMinimumDepth(); // Output: 2
            Console.WriteLine("Minimum Depth: " + minDepth1);

            // Example 2
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Left = new Node(2);
            Btree2.Root.Right = new Node(3);
            Btree2.Root.Left.Right = new Node(5);
            Btree2.Root.Right.Right = new Node(6);

            int minDepth2 = Btree2.FindMinimumDepth(); // Output: 3
            Console.WriteLine("Minimum Depth: " + minDepth2);

            Console.ReadKey();
        }      
    }
}


