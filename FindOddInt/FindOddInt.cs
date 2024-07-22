using System;
using System.Collections.Generic;

namespace FindOddInt
{
    public class FindOddInt
    {
        static void Main(string[] args)
        {
            int[] sampleData = { 1, 2, 3, 2, 3, 1, 3 };
            int result = FindInt(sampleData);
            Console.WriteLine($"The number with an odd count is: {result}");
        }

        public static int FindInt(int[] seq)
        {
            // if empty input, return -1
            if (seq.Length == 0)
            {
                return -1;
            }

            // Create an empty dictionary to store the counts of each number
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            // Iterate through each number in the array
            foreach (int num in seq)
            {
                if (numbers.ContainsKey(num))
                {
                    // Increment value for that number
                    numbers[num]++;
                }
                else
                {
                    // Add the number to the dictionary with an initial count of 1
                    numbers[num] = 1;
                }
            }

            // Iterate through the dictionary to find the key with an odd value
            foreach (var kvp in numbers)
            {
                if (kvp.Value % 2 != 0)
                {
                    // Return the key which has an odd count
                    return kvp.Key;
                }
            }

            // If no number has an odd count, return -1
            return -1;


        }
    }
}
