using challenges_and_data_structures;
using challenges_and_data_structures.DataStructures.LinkedList;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace challenges_and_data_structuresx
{
    public class Program
    {
        public static int[] ArrayReversal(int[] array)
        {
            int[] reversedArr = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArr[array.Length - 1 - i] = array[i];
            }

            return reversedArr;
        }

        static int MostFrequentNumber(int[] arr)
        {

            Dictionary<int, int> MostFrequency = new Dictionary<int, int>();
            int maxFrequency = 0;
            int mostFrequentNumber = arr[0];

            foreach (int num in arr)
            {
                if (MostFrequency.ContainsKey(num))
                {
                    MostFrequency[num]++;
                }
                else
                {
                    MostFrequency[num] = 1;
                }

                if (MostFrequency[num] > maxFrequency)
                {
                    maxFrequency = MostFrequency[num];
                    mostFrequentNumber = num;
                }
            }

            return mostFrequentNumber;

        }

        static void Print(int[] arr)
        {
            foreach (int key in arr)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /* Reversal Array */

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] result = ArrayReversal(arr);
            //Console.WriteLine("The Revers Array: ");
            //Print(result);
            //Console.WriteLine("\n");


            /* Most Frequent Number */
            //int[] arr1 = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            //int resultForMostFrequentNumber = MostFrequentNumber(arr1);
            //Console.WriteLine("The  Most Frequent Number: ");
            //Console.WriteLine(resultForMostFrequentNumber);

            /* Maximum Value */

            //int[] test1 = { 1, 3, 5, 7, 9 };
            //int[] test2 = { 7, 9, 13, 25, 5 };
            //int[] arr = { 10, 15, 8, 6, 12 };
            //int result = MaximumValue(arr);
            //Console.WriteLine($"The Max number: {result}");


            // Remove Middle Value
            //int[] input = {1, 2, 3, 4, 5}; // Output: [1, 2, 4, 5]

            //int[] input2 = { 27, 8, 15, 73, 27 }; // Output: [27, 8, 73, 27]

            //int[] input3 = { 7, 9, 13, 25, 5, 17 };  // Output: [7, 9, 13, 5, 17]

            //int[] result1 = RemoveMiddleValue(input);
            //int[] result2 = RemoveMiddleValue(input2);
            //int[] result3 = RemoveMiddleValue(input3);
            //Print(result1);
            //Print(result2);
            //Print(result3);

            // Middle Value
            //int[] testArray1 = { 1, 2, 3, 4 };
            //int[] result1 = MiddleValue(testArray1, 5);
            //Print(result1);  // Output: [1, 2, 5, 3, 4]

            //int[] testArray2 = { 10, 20, 30, 40, 50 };
            //int[] result2 = MiddleValue(testArray2, 25);
            //Print(result2);  // Output: [10, 20, 30, 25, 40, 50]

            //int[] testArray3 = { 7, 14, 21, 28 };
            //int[] result3 = MiddleValue(testArray3, 10);
            //Print(result3);  // Output: [7, 14, 10, 21, 28]


            //int[] testArray1 = { 1, 2, 3, 1, 2, 3 };
            //int[] testArray2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            //int[] testArray3 = { 5, 10, 16, 20, 10, 16 };

            //Console.WriteLine("Test Array 2: " + string.Join(" ", FindDuplicates(testArray2)));
            //Console.WriteLine("Test Array 3: " + string.Join(" ", FindDuplicates(testArray3)));

            //Print(testArray1);
            //Console.Write(" --> ");
            //Console.Write(string.Join(" ", FindDuplicates(testArray1)) + "\n");
            //Print(testArray2);
            //Console.Write(" --> ");
            //Console.Write(string.Join(" ", FindDuplicates(testArray2)) + "\n");
            //Print(testArray3);
            //Console.Write(" --> ");
            //Console.Write(string.Join(" ", FindDuplicates(testArray3)));

            //Console.WriteLine("Case One:");
            //int[] testArray1 = { 1, 2, 3, 0 };
            //int[] testArray2 = { 2, 3, 4, 9 };
            //Print(CommonElements(testArray1, testArray2));

            //Console.WriteLine("\nCase Two:");
            //int[] testArray3 = { 79, 8, 15 };
            //int[] testArray4 = { 23, 79, 8 };
            //Print(CommonElements(testArray3, testArray4));

            //Console.WriteLine("\nCase Three:");
            //int[] testArray5 = { 5, 10, 15, 20 };
            //int[] testArray6 = { 10, 15, 25 };
            //Print(CommonElements(testArray5, testArray6));

            //string result = ReverseWords.Reverse_Words("Hi for main");
            //Console.WriteLine(result);
            //string case1 = "csharp is programming language";
            //string case2 = "Reverse the words in this sentence";
            //string case3 = "challenges and data structures";

            //Console.WriteLine($"Input: \"{case1}\"");
            //Console.WriteLine($"Output: \"{ReverseWords.Reverse_Words(case1)}\"");
            //Console.WriteLine();
            //Console.WriteLine($"Input: \"{case2}\"");
            //Console.WriteLine($"Output: \"{ReverseWords.Reverse_Words(case2)}\"");
            //Console.WriteLine();
            //Console.WriteLine($"Input: \"{case3}\"");
            //Console.WriteLine($"Output: \"{ReverseWords.Reverse_Words(case3)}\"");
            //Console.WriteLine();

            //LinkedList list1 = new LinkedList();
            //int[] arr = {5, 10, 20, 30};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    list1.AddToHead(arr[i]);

            //}
            //Console.WriteLine("ADD from Head: ");
            //list1.PrintList();

            //LinkedList list = new LinkedList();
            //int[] arr1 = { 5, 10, 20, 30 };
            //for (int i = 0; i < arr1.Length; i++)
            //    list.AddToTial(arr1[i]);

            //Console.WriteLine("\nADD from Tail: ");
            //list.PrintList();

            //Console.WriteLine("\nRemov The Head");
            //list.RemoveHead();
            //list.PrintList();

            //Console.WriteLine("\nRemov The specific number");
            //list.Remove(10);
            //list.PrintList();

            //Console.WriteLine("\nIs includes number '20'");
            //bool result = list.Includes(20);
            //Console.WriteLine(result);

            //LinkedList duplicate1 = new LinkedList(); 
            //LinkedList duplicate2 = new LinkedList(); 
            //LinkedList duplicate3 = new LinkedList();

            //int[] values1 = { 1, 2, 3, 2, 4, 3 };
            //int[] values2 = { 5, 20, 20, 10, 5, 10 };
            //int[] values3 = { 7,7,7,7 };

            //Console.WriteLine("\nCase #1");
            //for (int i = 0; i < values1.Length; i++)
            //    duplicate1.AddToTial(values1[i]);
            //duplicate1.PrintList();
            //duplicate1.RemoveDuplicate();
            //duplicate1.PrintList();

            //Console.WriteLine("\nCase #2");
            //for (int i = 0; i < values2.Length; i++)
            //    duplicate2.AddToTial(values2[i]);
            //duplicate2.PrintList();
            //duplicate2.RemoveDuplicate();
            //duplicate2.PrintList();

            //Console.WriteLine("\nCase #3");
            //for (int i = 0; i < values3.Length; i++)
            //    duplicate3.AddToTial(values3[i]);
            //duplicate3.PrintList();
            //duplicate3.RemoveDuplicate();
            //duplicate3.PrintList();

            //LinkedList<int> list = new LinkedList<int>();

            //LinkedList list1 = new LinkedList();
            //LinkedList list_1 = new LinkedList();
            //LinkedList list2 = new LinkedList();
            //LinkedList list_2 = new LinkedList();
            //LinkedList list3 = new LinkedList();
            //LinkedList list_3 = new LinkedList();

            //int[] case1 = { 1, 3, 5 };
            //int[] case_1 = { 2, 4, 6 };
            //int[] case2 = { 5, 10, 15 };
            //int[] case_2 = { 2, 3, 20 }; 
            //int[] case3 = { 10, 20, 30 };
            //int[] case_3 = { 5, 15, 25, 35 };

            //AddToLinkedList(list1, case1);
            //AddToLinkedList(list_1, case_1);

            //Console.WriteLine("\nCase #1");
            //list1.PrintList();
            //list_1.PrintList();
            //// Merge and sort
            //list1.MergeLists(list1, list_1);
            //list1.SortedList();

            //Console.WriteLine("\nOutput #1");
            //list1.PrintList();

            //AddToLinkedList(list2, case2);
            //AddToLinkedList(list_2, case_2);

            //Console.WriteLine("\nCase #2");
            //list2.PrintList();
            //list_2.PrintList();
            //// Merge and sort
            //list2.MergeLists(list2, list_2);
            //list2.SortedList();

            //Console.WriteLine("\nOutput #2");
            //list2.PrintList();

            //AddToLinkedList(list3, case3);
            //AddToLinkedList(list_3, case_3);

            //Console.WriteLine("\nCase #3");
            //list3.PrintList();
            //list_3.PrintList();
            //// Merge and sort
            //list3.MergeLists(list3, list_3);
            //list3.SortedList();

            //Console.WriteLine("\nOutput #3");
            //list3.PrintList();
            //Console.WriteLine("");
            ////----------------------------------------------------------------------------------
            //// Create a new stack
            //Stack stack = new Stack();

            //// Push nodes onto the stack
            //stack.Push(10); // Stack: Top -> 10
            //stack.Push(5);  // Stack: Top -> 5 -> 10

            //// Print the stack
            //Console.WriteLine("Stack after pushing 10 and 5:");
            //stack.PrintStack();

            //// Pop a node from the stack
            //int popped = stack.Pop(); // popped: 5
            //Console.WriteLine($"\nPopped value: {popped}");

            //// Print the stack after popping
            //Console.WriteLine("Stack after popping the top value:");
            //stack.PrintStack();

            //// Peek the top node
            //int peeked = stack.Peek(); // peeked: 10
            //Console.WriteLine($"\nPeeked value: {peeked}");

            //// Check if the stack is empty
            //bool isEmpty = stack.IsEmpty(); // isEmpty: false
            //Console.WriteLine($"\nIs the stack empty? {isEmpty}");
            //Console.WriteLine("-------------------------------------------------------");
            ////-------------------------------------------------------
            //Queue queue = new Queue();
            //// Push nodes onto the queue
            //queue.Enqueue(10); // Queue: Top -> 10
            //queue.Enqueue(5);  // Queue: Top -> 10 -> 5

            //// Print the stack
            //Console.WriteLine("\nQueue after pushing 10 and 5:");
            //queue.PrintQueue();

            //// Pop a node from the Queue
            //int dequeue = queue.Dequeue(); // dequeue: 10
            //Console.WriteLine($"\nDequeue value: {dequeue}");

            //// Print the stack after popping
            //Console.WriteLine("Queue after dequeue the top value:");
            //stack.PrintStack();

            //// Peek the top node
            //int peeked2 = queue.Peek(); // peeked: 5
            //Console.WriteLine($"\nPeeked value: {peeked2}");

            //// Check if the stack is empty
            //bool isEmpty2 = queue.IsEmpty(); // isEmpty: false
            //Console.WriteLine($"\nIs the Queue empty? {isEmpty2}");

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Original Stack:");
            stack.PrintStack();

            stack.ReverseStack();

            Console.WriteLine("Reversed Stack:");
            stack.PrintStack();

            stack.Push(6);
            stack.Push(7);

            Console.WriteLine("After Adding More Elements:");
            stack.PrintStack();

            stack.ReverseStack();

            Console.WriteLine("After Reversing Again:");
            stack.PrintStack();

            Console.ReadKey();
        }

        static void AddToLinkedList(LinkedList list, int[] values)
        {
            foreach (var value in values)
            {
                list.AddToTial(value);
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


            for (int i = 0; i < arr1.Length; i++)
            {
                int value = arr1[i];
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (value == arr2[j])
                    {
                        newArr.Add(value);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return newArr.ToArray();
        }

    }
}


