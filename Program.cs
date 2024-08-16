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

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            // Original inorder traversal
            List<int> originalInorder = Btree.InorderTraversal();
            Console.WriteLine("Original Inorder: " + string.Join(", ", originalInorder)); // Output: [12, 8, 9, 4, 7]

            // Mirror the tree
            Btree.Mirror();

            // Inorder traversal after mirroring
            List<int> mirroredInorder = Btree.InorderTraversal();
            Console.WriteLine("Mirrored Inorder: " + string.Join(", ", mirroredInorder)); // Output: [7, 4, 9, 8, 12]

            Console.ReadKey();
        }      
    }
}


