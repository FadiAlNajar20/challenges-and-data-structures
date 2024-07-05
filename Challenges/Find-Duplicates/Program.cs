using challenges_and_data_structures;
using static System.Net.Mime.MediaTypeNames;

namespace challenges_and_data_structures
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
            string case1 = "csharp is programming language";
            string case2 = "Reverse the words in this sentence";
            string case3 = "challenges and data structures";

            Console.WriteLine($"Input: \"{case1}\"");
            Console.WriteLine($"Output: \"{ReverseWords.Reverse_Words(case1)}\"");
            Console.WriteLine();
            Console.WriteLine($"Input: \"{case2}\"");
            Console.WriteLine($"Output: \"{ReverseWords.Reverse_Words(case2)}\"");
            Console.WriteLine();
            Console.WriteLine($"Input: \"{case3}\"");
            Console.WriteLine($"Output: \"{ReverseWords.Reverse_Words(case3)}\"");
            Console.WriteLine();
            
            Console.ReadKey();
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


