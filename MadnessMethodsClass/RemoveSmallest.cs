using System;
using System.Collections.Generic;

namespace MadnessMethodsClass
{
    internal class RemoveSmallest
    {
        // Method to remove the smallest number from an array
        public static List<int> RemoveSmallestMethod(List<int> numbers)
        {
            // Check if the input list is empty. If it is, return an empty list.
            // Find the smallest value in the list.
            // Create a new list that is a copy of the original list.
            // Remove the first occurrence of the smallest value from the new list.
            // Return the new list.
            // If the array is empty, return the array

            // Check if the list is empty
            if (numbers == null || numbers.Count == 0)
            {
                return new List<int>();
            }

            // Iterate through the list to find the smallest value
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // Create a copy of the original list
            List<int> result = new List<int>(numbers);

            // Remove the first occurrence of the smallest value
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == min)
                {
                    result.RemoveAt(i);
                    break;
                }
            }

            // Return the new list
            return result;
        }
    }
}
