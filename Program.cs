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

            Console.WriteLine("\nBinary Search Tree:");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            Console.WriteLine("Contains 7: " + bst.Contains(7)); 
            Console.WriteLine("Contains 5: " + bst.Contains(5)); 
            Console.WriteLine("Contains 20: " + bst.Contains(20)); 

            bst.Remove(5);
            Console.WriteLine("Contains 5 after removal: " + bst.Contains(5)); 
            Console.ReadKey();
        }      
    }
}


