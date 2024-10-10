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
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(10);
            tree.Root.Left.Left = new Node(5);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Left.Right.Left = new Node(20);
            tree.Root.Left.Right.Right = new Node(35);
            tree.Root.Right = new Node(50);
            tree.Root.Right.Right = new Node(60);


            Console.WriteLine("Original Binary Tree:");
            tree.Print(tree.Root);

            tree.ConvertToBST();

            Console.WriteLine("\nConverted Binary Search Tree:");
            tree.Print(tree.Root);

            Console.ReadKey();
        }      
    }
}


