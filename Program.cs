namespace challenges_and_data_structures
{
    internal class Program
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
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] result = ArrayReversal(arr);
            Console.WriteLine("The Revers Array: ");
            Print(result);
            Console.WriteLine("\n");



            int[] arr1 = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int resultForMostFrequentNumber = MostFrequentNumber(arr1);
            Console.WriteLine("The  Most Frequent Number: ");
            Console.WriteLine(resultForMostFrequentNumber);
        }



    }
}
