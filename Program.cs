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

            LinkedList list1 = new LinkedList();
            list1.AddToTail(1);
            list1.AddToTail(2);
            list1.AddToTail(3);
            list1.AddToTail(4);
            list1.AddToTail(5);
            list1.AddToTail(6);

            Console.WriteLine("Original List:");
            list1.PrintList();

            int k = 2;
            list1.RotateLeft(k);

            Console.WriteLine($"List after rotating left by {k} places:");
            list1.PrintList();

            LinkedList list2 = new LinkedList();
            list2.AddToTail(10);
            list2.AddToTail(20);
            list2.AddToTail(30);
            list2.AddToTail(40);
            list2.AddToTail(50);

            Console.WriteLine("\nOriginal List:");
            list2.PrintList();

            k = 3;
            list2.RotateLeft(k);

            Console.WriteLine($"List after rotating left by {k} places:");
            list2.PrintList();


            LinkedList list3 = new LinkedList();
            list3.AddToTail(5);
            list3.AddToTail(10);
            list3.AddToTail(15);
            list3.AddToTail(20);
            Console.WriteLine("\nOriginal List:");
            list3.PrintList();

            k = 1;
            list3.RotateLeft(k);

            Console.WriteLine($"List after rotating left by {k} places:");
            list3.PrintList();
            Console.ReadKey();
        }

        static void AddToLinkedList(LinkedList list, int[] values)
        {
            foreach (var value in values)
            {
                list.AddToTail(value);
            }
        }

        public static int MaximumValue(int[] arr)   
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int[] RemoveMiddleValue(int[] array)
        {
            int middleIndex = array.Length / 2;
            int[] modifiedArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != middleIndex)
                    modifiedArray[j++] = array[i];
            }
            return modifiedArray;
        }

        public static int[] MiddleValue(int[] array, int valueToAdd)
        {
            int middleIndex = (array.Length + 1) / 2;
            int[] modifiedArray = new int[array.Length + 1];

            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                if (middleIndex == j)
                {
                    modifiedArray[j++] = valueToAdd;
                }
                modifiedArray[j] = array[i];
            }

            return modifiedArray;
        }

            public static int[] FindDuplicates(int[] nums)
            {
                Dictionary<int, int> directory = new Dictionary<int, int>();

                foreach (int num in nums)
                {
                    if (directory.ContainsKey(num))
                        directory[num]++;
                    else
                        directory.Add(num, 1);
                }

                List<int> storDuplicates = new List<int>();

                foreach (var kvp in directory)
                {
                    if (kvp.Value > 1)
                    storDuplicates.Add(kvp.Key);
                }

                return storDuplicates.ToArray();
            }

        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            List<int> newArr = new List<int>();

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            Btree.PrintRightView();  

            Console.ReadKey();
        }      
    }
}


