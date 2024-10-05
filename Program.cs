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
            Btree1.Root.Right.Right = new Node(6);
            Btree1.Root.Left.Left.Left = new Node(7);
            Btree1.Root.Left.Right.Right = new Node(8);
            Btree1.PrintRightView();
            int maxLevel1 = Btree1.FindMaxLevelNodes();
            Console.WriteLine("Max level: " + maxLevel1); 

            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Left = new Node(2);
            Btree2.Root.Right = new Node(3);
            Btree2.Root.Left.Left = new Node(4);
            Btree2.Root.Left.Right = new Node(5);
            Btree2.Root.Right.Right = new Node(7);
            Btree2.Root.Left.Left.Left = new Node(8);
            Btree2.Root.Left.Right.Left = new Node(9);
            Btree2.Root.Right.Right.Left = new Node(10);

            int maxLevel2 = Btree2.FindMaxLevelNodes();
            Console.WriteLine("Max level: " + maxLevel2); 

            Console.ReadKey();
        }      
    }
}


