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
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(5);
            Btree.Root.Right = new Node(20);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(15);
            Btree.Root.Right.Right = new Node(25);

            try
            {
                int secondMax = Btree.FindSecondMax();
                Console.WriteLine("The second maximum value is: " + secondMax); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }      
    }
}


